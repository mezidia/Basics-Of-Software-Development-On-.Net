using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;

namespace Additional
{
    public class Zone43
    {
        #region Lab8-2

        private FileInfo file;
        private Mutex fileLock = new Mutex();

        public Zone43(FileInfo f)
        {
            file = f;
            File.Delete(file.FullName);
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

        #endregion Lab8-2
    }
}
