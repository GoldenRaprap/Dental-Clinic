using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    public class DbConfig
    {
        public string ConnectionString { get; }
        public DbConfig(string connectionString) => ConnectionString = connectionString;
    }

    public class DoctorRepository
    {
        private readonly DbConfig _cfg;
        public DoctorRepository(DbConfig cfg) => _cfg = cfg;

        public List<Doctor> GetAll()
        {
            var list = new List<Doctor>();
            using (var conn = new SqlConnection(_cfg.ConnectionString))
            using (var cmd = new SqlCommand("SELECT doctor_id, full_name FROM Doctors ORDER BY full_name", conn))
            {
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        list.Add(new Doctor { DoctorId = r.GetInt32(0), FullName = r.GetString(1) });
                }
            }
            return list;
        }
    }

    public class AvailabilityRepository
    {
        private readonly DbConfig _cfg;
        public AvailabilityRepository(DbConfig cfg) => _cfg = cfg;

        public List<AvailabilityEntry> GetByDoctor(int doctorId)
        {
            var list = new List<AvailabilityEntry>();
            using (var conn = new SqlConnection(_cfg.ConnectionString))
            using (var cmd = new SqlCommand("SELECT day_of_week, hour_slot, status, is_blocked FROM Availability WHERE doctor_id = @doc", conn))
            {
                cmd.Parameters.Add("@doc", SqlDbType.Int).Value = doctorId;
                conn.Open();
                using (var r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        var day = r.IsDBNull(0) ? "" : r.GetString(0);
                        TimeSpan ts = TimeSpan.Zero;
                        if (!r.IsDBNull(1))
                        {
                            try { ts = r.GetTimeSpan(1); }
                            catch { TimeSpan.TryParse(r.GetValue(1).ToString(), out ts); }
                        }
                        var status = r.IsDBNull(2) ? "" : r.GetString(2);
                        var isBlocked = !r.IsDBNull(3) && r.GetBoolean(3);
                        list.Add(new AvailabilityEntry { DayOfWeek = day, HourSlot = ts, Status = status, IsBlocked = isBlocked });
                    }
                }
            }
            return list;
        }

        // Replace all availability rows for a doctor with the provided list
        public void ReplaceForDoctor(int doctorId, IEnumerable<AvailabilityEntry> rows)
        {
            using (var conn = new SqlConnection(_cfg.ConnectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (var del = new SqlCommand("DELETE FROM Availability WHERE doctor_id = @doc", conn, tran))
                        {
                            del.Parameters.Add("@doc", SqlDbType.Int).Value = doctorId;
                            del.ExecuteNonQuery();
                        }

                        using (var ins = new SqlCommand(
                            "INSERT INTO Availability (doctor_id, day_of_week, hour_slot, status, is_blocked) VALUES (@doc,@day,@hour,@status,@isBlocked)",
                            conn, tran))
                        {
                            ins.Parameters.Add(new SqlParameter("@doc", SqlDbType.Int));
                            ins.Parameters.Add(new SqlParameter("@day", SqlDbType.NVarChar, 50));
                            ins.Parameters.Add(new SqlParameter("@hour", SqlDbType.Time));
                            ins.Parameters.Add(new SqlParameter("@status", SqlDbType.NVarChar, 200));
                            ins.Parameters.Add(new SqlParameter("@isBlocked", SqlDbType.Bit));

                            foreach (var r in rows)
                            {
                                if (string.IsNullOrWhiteSpace(r.Status) && !r.IsBlocked) continue;
                                ins.Parameters["@doc"].Value = doctorId;
                                ins.Parameters["@day"].Value = r.DayOfWeek;
                                ins.Parameters["@hour"].Value = r.HourSlot;
                                ins.Parameters["@status"].Value = r.Status ?? "";
                                ins.Parameters["@isBlocked"].Value = r.IsBlocked ? 1 : 0;
                                ins.ExecuteNonQuery();
                            }
                        }

                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}