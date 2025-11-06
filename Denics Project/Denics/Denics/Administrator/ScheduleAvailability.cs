using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Services
{
    public class ScheduleAvailability
    {
        private readonly AvailabilityRepository _repo;
        public ScheduleAvailability(AvailabilityRepository repo) => _repo = repo;

        public Dictionary<(string day, TimeSpan hour), AvailabilityEntry> BuildLookup(int doctorId)
        {
            var list = _repo.GetByDoctor(doctorId);
            var dict = new Dictionary<(string, TimeSpan), AvailabilityEntry>();
            foreach (var e in list)
            {
                var day = NormalizeDay(e.DayOfWeek);
                if (day == null) continue;
                dict[(day, e.HourSlot)] = new AvailabilityEntry { DoctorId = doctorId, DayOfWeek = day, HourSlot = e.HourSlot, Status = e.Status, IsBlocked = e.IsBlocked };
            }
            return dict;
        }

        public void SaveForDoctor(int doctorId, IEnumerable<AvailabilityEntry> rows) => _repo.ReplaceForDoctor(doctorId, rows);

        private static string NormalizeDay(string raw)
        {
            if (string.IsNullOrWhiteSpace(raw)) return null;
            var map = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "sun", "Sunday" }, { "sunday", "Sunday" },
                { "mon", "Monday" }, { "monday", "Monday" },
                { "tue", "Tuesday" }, { "tues", "Tuesday" }, { "tuesday", "Tuesday" },
                { "wed", "Wednesday" }, { "wednesday", "Wednesday" },
                { "thu", "Thursday" }, { "thur", "Thursday" }, { "thursday", "Thursday" },
                { "fri", "Friday" }, { "friday", "Friday" },
                { "sat", "Saturday" }, { "saturday", "Saturday" }
            };
            return map.TryGetValue(raw.Trim(), out var t) ? t : null;
        }
    }
}