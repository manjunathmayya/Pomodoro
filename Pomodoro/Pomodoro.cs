using System;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Pomodoro
{
    public interface IPomodoro
    {
        void start();
        void stop();
        void reset();
        bool isRunning();
    }

    public class Pomodoro : IPomodoro
    {
        private Label _label;
        Timer timer;
        private int _minutes;
        private DateTime _pomodoro_duration;
        private string _task;

        public Pomodoro(string task, Label label, int minutes)
        {
            CreateNewTimer();

            _task = task;
            _label = label;
            _minutes = minutes;
            init();
        }

        private void CreateNewTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;            
            timer.Tick += new EventHandler(this.timer_Tick);
        }

        public void start()
        {
            timer.Start();
            Log("Start");
        }

        public void stop()
        {
            timer.Stop();
            Log("Stop");
        }

        public void reset()
        {
            init();
            Log("Reset");
        }

        private void init()
        {
            UpdatePomodoroDuration(_minutes, 0);
            _label.Text = FormatTime(_minutes, 0);
        }

        public bool isRunning()
        {
            return timer.Enabled;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int minutes = _pomodoro_duration.Minute;
            int seconds = _pomodoro_duration.Second;

            seconds -= 1;
            if (seconds < 0)
            {
                seconds = 59;
                minutes -= 1;
            }

            if (TimeUp(minutes))
            {
                stop();
                reset();
                NotifyUser();
                Log("Completed");
            }
            else
            {
                UpdatePomodoroDuration(minutes, seconds);
                _label.Text = FormatTime(minutes, seconds);
            }
        }

        private static void NotifyUser()
        {
            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipTitle = "Pomodoro: Times up!",
                BalloonTipText = "Switch between (Work <-> break) modes",
            };

            notification.ShowBalloonTip(1000);
            notification.Dispose();
        }

        private static bool TimeUp(int minutes)
        {
            return minutes < 0;
        }

        private void UpdatePomodoroDuration(int minutes, int seconds)
        {
            _pomodoro_duration =
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, minutes, seconds);
        }

        private static string FormatTime(int minutes, int seconds)
        {
            string time = "";

            if (minutes < 10)
            {
                time += "0" + minutes;
            }
            else
            {
                time += minutes;
            }

            time += ":";

            if (seconds < 10)
            {
                time += "0" + seconds;
            }
            else
            {
                time += seconds;
            }

            return time;
        }

        private void Log(string text)
        {
            Logger.Log("Task: " + _task + "; " + text);
        }
    }
}
