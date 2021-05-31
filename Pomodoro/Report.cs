using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Globalization;

namespace Pomodoro
{
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
            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("Task");
            dtReport.Columns.Add("TimeTaken");
            var query = from row in dtTaskInfo.AsEnumerable()
                        group row by row.Field<string>("Task") into grp
                        select new
                        {
                            Task = grp.Key,
                            sum = grp.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken")== "" ? 0: r.Field<string>("TimeTaken")))
                        };
            foreach (var grp in query)
            {
                int seconds = grp.sum % 60;
                int minutes = grp.sum / 60;
                string time = minutes + ":" + seconds.ToString("00");
                dtReport.Rows.Add(grp.Task, time);
            }

            grdTaskInfo.DataSource = dtReport;

        }

        private void lblTaskLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadTaskInfo();
        }

        private void lblDayWiseReport_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("Task");
            dtReport.Columns.Add("TimeTaken");

            var groups = dtTaskInfo.AsEnumerable().GroupBy(row => Convert.ToDateTime(row["Time"]).ToString("dd-MMM-yy"));

            foreach(var group in groups)
            {
                var groups2 = group.OrderBy(row => row["Time"]).GroupBy(row => row["Task"]);



                var sum = group.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken") == "" ? 0 : r.Field<string>("TimeTaken")));
                int seconds = sum % 60;
                int minutes = sum / 60;
                string time = minutes + ":" + seconds.ToString("00");



                dtReport.Rows.Add("", "");
                dtReport.Rows.Add( group.Key, time);
                dtReport.Rows.Add("", "");

                foreach (var group2 in groups2)
                {
                    sum = group2.Sum(r => Convert.ToInt32(r.Field<string>("TimeTaken") == "" ? 0 : r.Field<string>("TimeTaken")));

                    seconds = sum % 60;
                    minutes = sum / 60;
                    time = minutes + ":" + seconds.ToString("00");


                    dtReport.Rows.Add(group2.Key, time);
                }
            }

            grdTaskInfo.DataSource = dtReport;
        }
    }
}
