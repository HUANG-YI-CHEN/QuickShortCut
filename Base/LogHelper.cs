using System;
using System.IO;
using System.Text;

namespace QuickShortCut.Base
{
    class LogHelper
    {
        private static readonly object LockFile = new object();
        /// <summary>
        /// 建立 Log 紀錄, 路徑: <Execution Path>\Log\<yyyyMMdd.txt>
        /// </summary>
        /// <param name="Message"></param>
        public static void LogTrace(string Message)
        {
            LogTrace(string.Empty, Message);
        }
        /// <summary>
        /// 建立 Log 紀錄, 路徑: <Execution Path>\Log\<UserDirName>\<yyyyMMdd.txt>
        /// </summary>
        /// <param name="UserDirName"></param>
        /// <param name="Message"></param>
        public static void LogTrace(string UserDirName, string Message)
        {
            DateTime GetNow = DateTime.Now;
            string DirBase = AppDomain.CurrentDomain.BaseDirectory + @"\Log\";
            string DirName = DirBase + (string.IsNullOrEmpty(UserDirName) ? String.Empty : UserDirName + @"\");
            string FileName = DirName + GetNow.ToString("yyyyMMdd") + ".txt";
            if (!Directory.Exists(DirBase))
                Directory.CreateDirectory(DirBase);
            if (!Directory.Exists(DirName))
                Directory.CreateDirectory(DirName);
            if (!File.Exists(FileName))
                using (var f = File.Create(FileName)) { f.Close(); }

            using (var fs = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var log = new StreamWriter(fs, Encoding.Default))
                {
                    lock (LockFile)
                    {
                        log.WriteLine("[" + GetNow.ToString("yyyy/MM/dd HH:mm:ss.fff") + "] " + Message);
                    }
                }
            }
        }
    }
}
