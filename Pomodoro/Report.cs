using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
    }
}
