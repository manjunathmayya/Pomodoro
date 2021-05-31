using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;

namespace Pomodoro
{
    public abstract class ReportTemplate
    {
        public DataTable dtReport = new DataTable();

        public ReportTemplate()
        {
            CreateDataTable();
        }
         
        
        private void CreateDataTable() 
        {
            dtReport.Columns.Add("Task");
            dtReport.Columns.Add("TimeTaken");
        }

        protected static string seconds_to_minute(int timeTaken)
        {
            int seconds = timeTaken % 60;
            int minutes = timeTaken / 60;
            string time = minutes + ":" + seconds.ToString("00");
            return time;
        }

        public abstract DataTable GetReportData(DataTable dtTaskInfo);       

    }

    public class TaskTimeReport:ReportTemplate
    {
        public override DataTable GetReportData(DataTable dtTaskInfo)
        {
            var query = from row in dtTaskInfo.AsEnumerable()
                        group row by row.Field<string>("Task") into grp
                        select new
                        {
                            Task = grp.Key,
                            sum = grp.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken") == "" ? 0 : r.Field<string>("TimeTaken")))
                        };
            foreach (var grp in query)
            {
                dtReport.Rows.Add(grp.Task, seconds_to_minute(grp.sum));
            }

            return dtReport;
        }
    }

    public class DayWiseReport : ReportTemplate
    {
        public override DataTable GetReportData(DataTable dtTaskInfo)
        {
            var groups = dtTaskInfo.AsEnumerable().GroupBy(row => Convert.ToDateTime(row["Time"]).ToString("dd-MMM-yy"));

            foreach (var group in groups)
            {
                var groups2 = group.OrderBy(row => row["Time"]).GroupBy(row => row["Task"]);

                var timeTaken = group.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken") == "" ? 0 : r.Field<string>("TimeTaken")));

                dtReport.Rows.Add("", "");
                dtReport.Rows.Add(group.Key, seconds_to_minute(timeTaken));
                dtReport.Rows.Add("", "");

                foreach (var group2 in groups2)
                {
                    timeTaken = group2.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken") == "" ? 0 : r.Field<string>("TimeTaken")));
                    dtReport.Rows.Add(group2.Key, seconds_to_minute(timeTaken));
                }
            }

            return dtReport;
        }
    }


    public partial class Report : Form
    {
        private string log_file = "C:\\pomodoro_log_file.txt";
        private DataTable dtTaskInfo;

        public Report()
        {
            InitializeComponent();

            LoadTaskInfo();
        }

        private void LoadTaskInfo()
        {
            createTaskInfoDataTable();

            string[] log = File.ReadAllLines(log_file);

            foreach (var line in log)
            {
                dtTaskInfo.Rows.Add(line.Split(';'));
            }

            grdTaskInfo.DataSource = dtTaskInfo;
        }

        private void createTaskInfoDataTable()
        {
            dtTaskInfo = new DataTable();
            dtTaskInfo.Columns.Add("Time");
            dtTaskInfo.Columns.Add("Item");
            dtTaskInfo.Columns.Add("Task");
            dtTaskInfo.Columns.Add("State");
            dtTaskInfo.Columns.Add("TimeTaken");
        }

        private void lblTaskTimeReport_MouseClick(object sender, MouseEventArgs e)
        {
            TaskTimeReport taskTimeReport = new TaskTimeReport();
            grdTaskInfo.DataSource = taskTimeReport.GetReportData(dtTaskInfo);

        }

        private void lblTaskLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTaskInfo();
        }

        private void lblDayWiseReport_MouseClick(object sender, MouseEventArgs e)
        {
            DayWiseReport dayWiseReport = new DayWiseReport();
            grdTaskInfo.DataSource = dayWiseReport.GetReportData(dtTaskInfo);
        }

        
    }
}
