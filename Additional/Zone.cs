using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Linq;

namespace Hotel.Project
{
    public class Zone
    {
        #region Lab8-2

        private FileInfo file;
        private readonly object fileLock = new object();

        public Zone(FileInfo f)
        {
            file = f;
            if (File.Exists(file.FullName))
            {
                File.Delete(file.FullName);
            }

        }
        public string ReadFromFile(int line)
        {
            lock (fileLock)
            {
                using (var sr = new StreamReader(file.FullName))
                {
                    for (int i = 1; i < line; i++)
                        sr.ReadLine();
                    return sr.ReadLine();
                }
            }
        }

        public int WriteToFile(string text)
        {
            lock (fileLock)
            {
                using (StreamWriter w = File.AppendText(file.FullName))
                {
                    w.WriteLine(text);
                    Console.WriteLine("Записано строку \"" + text + "\"");
                }
                return File.ReadLines(file.FullName).Count();
            }
        }

        #endregion Lab8-2
    }
}
