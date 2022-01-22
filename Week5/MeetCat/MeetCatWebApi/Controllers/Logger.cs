using System;

namespace MeetCatWebApi
{
    public class Logger
    {
        string _Path = @".\Log\"; //log file path
        string _Filename = DateTime.Now.ToString("yyyyMMdd"); //formatting date

        private static int logCount = 0;

        public void createLog(string message)
        {
            FileStream fs = new FileStream(_Path + _Filename + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            logCount += 1;

            //find the current time
            string utcTime = DateTime.UtcNow.ToString("HH:mm:ss");
            //write line by line
            sw.WriteLine(logCount + ".\t" + message + "\t" + "Time: " + utcTime);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}