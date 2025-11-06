namespace Denics.Administrator
{
    partial class ReportPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            cmbReportType = new ComboBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnGenerate = new Button();
            dgvReport = new DataGridView();
            chartAppointments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPatientsPerDoctor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPatientsPerService = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPatientsPerDoctor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPatientsPerService).BeginInit();
            SuspendLayout();
            // 
            // cmbReportType
            // 
            cmbReportType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReportType.Location = new Point(189, 65);
            cmbReportType.Margin = new Padding(3, 4, 3, 4);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(228, 28);
            cmbReportType.TabIndex = 0;
            cmbReportType.SelectedIndexChanged += cmbReportType_SelectedIndexChanged;
            // 
            // dtpStart
            // 
            dtpStart.Location = new Point(440, 65);
            dtpStart.Margin = new Padding(3, 4, 3, 4);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(228, 27);
            dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            dtpEnd.Location = new Point(691, 65);
            dtpEnd.Margin = new Padding(3, 4, 3, 4);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(228, 27);
            dtpEnd.TabIndex = 2;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(943, 65);
            btnGenerate.Margin = new Padding(3, 4, 3, 4);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(137, 33);
            btnGenerate.TabIndex = 3;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerateReport_Click;
            // 
            // dgvReport
            // 
            dgvReport.AccessibleRole = AccessibleRole.IpAddress;
            dgvReport.AllowUserToAddRows = false;
            dgvReport.AllowUserToDeleteRows = false;
            dgvReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReport.Location = new Point(189, 100);
            dgvReport.Margin = new Padding(3, 4, 3, 4);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.Size = new Size(581, 317);
            dgvReport.TabIndex = 4;
            // 
            // chartAppointments
            // 
            chartArea1.Name = "ChartArea1";
            chartAppointments.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartAppointments.Legends.Add(legend1);
            chartAppointments.Location = new Point(189, 445);
            chartAppointments.Name = "chartAppointments";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartAppointments.Series.Add(series1);
            chartAppointments.Size = new Size(503, 292);
            chartAppointments.TabIndex = 5;
            chartAppointments.Text = "chart1";
            title1.Name = "Total Number of Appointments";
            title1.Text = "Total Number of Appointments";
            chartAppointments.Titles.Add(title1);
            // 
            // chartStatus
            // 
            chartArea2.Name = "ChartArea1";
            chartStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartStatus.Legends.Add(legend2);
            chartStatus.Location = new Point(825, 105);
            chartStatus.Name = "chartStatus";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.Label = "#PERCENT{P0}";
            series2.Legend = "Legend1";
            series2.LegendText = "#VALX";
            series2.Name = "Series1";
            chartStatus.Series.Add(series2);
            chartStatus.Size = new Size(288, 304);
            chartStatus.TabIndex = 6;
            chartStatus.Text = "             ";
            title2.Name = "Title1";
            title2.Text = "Appointment Status Distribution";
            chartStatus.Titles.Add(title2);
            // 
            // chartPatientsPerDoctor
            // 
            chartArea3.Name = "ChartArea1";
            chartPatientsPerDoctor.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartPatientsPerDoctor.Legends.Add(legend3);
            chartPatientsPerDoctor.Location = new Point(822, 435);
            chartPatientsPerDoctor.Name = "chartPatientsPerDoctor";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.LegendText = "#VALX (#VAL)";
            series3.Name = "Patients";
            series3.XValueMember = "DoctorName";
            series3.YValueMembers = "TotalPatients";
            chartPatientsPerDoctor.Series.Add(series3);
            chartPatientsPerDoctor.Size = new Size(291, 338);
            chartPatientsPerDoctor.TabIndex = 7;
            chartPatientsPerDoctor.Text = "chart1";
            title3.Name = "Title1";
            title3.Text = "Number of Patients per Doctor";
            chartPatientsPerDoctor.Titles.Add(title3);
            // 
            // chartPatientsPerService
            // 
            chartArea4.Name = "ChartArea1";
            chartPatientsPerService.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            chartPatientsPerService.Legends.Add(legend4);
            chartPatientsPerService.Location = new Point(1162, 128);
            chartPatientsPerService.Name = "chartPatientsPerService";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Label = "#PERCENT{P1}";
            series4.Legend = "Legend1";
            series4.LegendText = "#VALX";
            series4.Name = "SPatients";
            series4.XValueMember = "ServiceName";
            series4.YValueMembers = "TotalPatients";
            chartPatientsPerService.Series.Add(series4);
            chartPatientsPerService.Size = new Size(308, 331);
            chartPatientsPerService.TabIndex = 8;
            chartPatientsPerService.Text = "chart1";
            title4.Name = "Services";
            title4.Text = "Number of Patients per Service";
            chartPatientsPerService.Titles.Add(title4);
            // 
            // ReportPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 881);
            Controls.Add(chartPatientsPerService);
            Controls.Add(chartStatus);
            Controls.Add(chartAppointments);
            Controls.Add(dgvReport);
            Controls.Add(btnGenerate);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(cmbReportType);
            Controls.Add(chartPatientsPerDoctor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportPage";
            Text = "Report";
            Load += ReportPage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPatientsPerDoctor).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPatientsPerService).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbReportType;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnGenerate;
        private DataGridView dgvReport;
        private Label lblSummary;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAppointments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPatientsPerDoctor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPatientsPerService;
    }
}
