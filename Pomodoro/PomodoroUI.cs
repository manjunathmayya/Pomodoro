using System;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class PomodoroUI : Form
    {
        private IPomodoro pomodoro;

        public PomodoroUI()
        {
            InitializeComponent();
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pomodoro != null && pomodoro.isRunning())
            {
                MessageBox.Show("Timer already running!. Stop and start in case you want to switch timers");
            }
            else
            {
                if (CanStartPomodoro())
                {
                    Logger.Log("Task: " + txtTask.Text + "; Start");
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
                pomodoro.stop();
                Logger.Log("Task: " + txtTask.Text + "; Start");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(pomodoro!=null) 
                pomodoro.reset();
        }


        private Pomodoro CreatePomodoroTimer()
        {
            if (rbtnPomodoro.Checked)
                return new Pomodoro(lblTime, 25);

            if (rbtnShortBreak.Checked)
                return new Pomodoro(lblTime, 5);
            
            if(rbtnLongBreak.Checked)
                return new Pomodoro(lblTime, 15);

            return new Pomodoro(lblTime, Convert.ToInt32(txtCustomTime.Text.Trim()));
        }
    }

    




}
