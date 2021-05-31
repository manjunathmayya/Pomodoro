using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Pomodoro
{
    public partial class PomodoroUI : Form
    {
        private IPomodoro pomodoro;
        private string[] tasks;
        private string taskFileName = "tasks.txt";

        public PomodoroUI()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void LoadTasks()
        {
            tasks = File.ReadAllLines(taskFileName);
            ddlTasks.Items.AddRange(tasks);
            if(ddlTasks.Items.Count>0)
            {
                ddlTasks.SelectedIndex = 0;
            }
            else
            {
                ddlTasks.Text = "New Task";
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {            

            if (pomodoro != null && pomodoro.isRunning())
            {
                MessageBox.Show("Timer already running!");
            }
            else if(pomodoro != null && pomodoro.isPaused())
            {
                MessageBox.Show("Timer Paused! Cant Start now.");
            }
            else
            {
                if (CanStartPomodoro())
                {
                    pomodoro = CreatePomodoroTimer();
                    pomodoro.start();
                }
                else
                {
                    MessageBox.Show("Please enter valid minutes, without decimal values");
                }
            }

        }

        private bool CanStartPomodoro()
        {
            if (rbtnCustom.Checked)
            {
                if (int.TryParse(txtCustomTime.Text.Trim(), out int time))
                    return true;
                else
                    return false;
            }
            else
            {
                return true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (pomodoro != null)
            {
                if (pomodoro.isRunning())
                {
                    pomodoro.pause();
                }
                else
                {
                    pomodoro.resume();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (pomodoro != null)
            {
                pomodoro.reset();
            }
        }


        private Pomodoro CreatePomodoroTimer()
        {
            if (rbtnPomodoro.Checked)
                return new Pomodoro(ddlTasks.Text, lblTime, 25);

            if (rbtnShortBreak.Checked)
                return new Pomodoro("Short break", lblTime, 5);
            
            if(rbtnLongBreak.Checked)
                return new Pomodoro("Long break", lblTime, 15);

            return new Pomodoro(ddlTasks.Text, lblTime, Convert.ToInt32(txtCustomTime.Text.Trim()));
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            ddlTasks.Items.Add(ddlTasks.Text);
            UpdateTaskFile();
            Logger.Log(ddlTasks.Text, "Added");
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            Logger.Log(ddlTasks.Text, "Deleted");
            ddlTasks.Items.Remove(ddlTasks.Text);
            UpdateTaskFile();

        }

        private void UpdateTaskFile()
        {
            List<string> taskList = new List<string>();
            foreach (var item in ddlTasks.Items)
            {
                taskList.Add(item.ToString());
            }

            File.WriteAllLines(taskFileName, taskList.ToArray());
        }

        private void lblReport_MouseClick(object sender, MouseEventArgs e)
        {
            Report report = new Report();
            report.Show();
        }
    }

    




}
