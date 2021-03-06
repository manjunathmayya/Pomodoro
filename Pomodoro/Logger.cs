using System;
using System.IO;

namespace Pomodoro
{
    public enum Levels
    {
        INFO,
        DEBUG,
        ERROR,
        SUCCES,
        ALL
    }

    public class Logger
    {
        private static Levels selectedLevel;
        public static void StartLogging(Levels level)
        {
            selectedLevel = level;
        }

        public static void Log(string text, Levels level = Levels.INFO)
        {
            if (selectedLevel == Levels.ALL || selectedLevel == level)
            {
                text = DateTime.Now.ToString() + "; " + text;
                File.AppendAllText(@"c:\pomodoro_log_file.txt", text + Environment.NewLine);
            }
        }

        public static void Log(string task, string text)
        {
            Logger.Log("Task; " + task + "; " + text + ";");
        }

        public static void LogWithElapsedTime(string task, string text, string elapsedTime)
        {
            Logger.Log("Task; " + task + "; " + text + ";" +elapsedTime);
        }
    }
}

