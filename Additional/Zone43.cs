using System;
using System.IO;
using System.Threading;
using System.Linq;

namespace Additional
{
    public class Zone43
    {
        #region Lab8-3

        private readonly FileInfo file;
        private readonly Mutex fileLock = new Mutex();

        public Zone43(FileInfo f)
        {
            file = f;

            if (File.Exists(file.FullName))
            {
                File.Delete(file.FullName);
            }
        }

        public string ReadFromFile(int line)
        {
            fileLock.WaitOne();
            string lastLine;

            using (var sr = new StreamReader(file.FullName))
            {
                for (int i = 1; i < line; i++)
                {
                    sr.ReadLine();
                }
                lastLine = sr.ReadLine();
            }
            fileLock.ReleaseMutex();

            return lastLine;
        }

        public int WriteToFile(string text)
        {
            fileLock.WaitOne();

            using (StreamWriter w = File.AppendText(file.FullName))
                {
                    w.WriteLine(text);
                    Console.WriteLine("Записано строку \"" + text + "\"");
                }
            fileLock.ReleaseMutex();

            return File.ReadLines(file.FullName).Count();
        }

        #endregion Lab8-3
    }
}
