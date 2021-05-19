using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zone43
{
    class Program
    {
        private static Mutex fileLockM = new Mutex();
        static void Main(string[] args)
        {
            #region 4.3
            int counterStrings = 5;
            int countLines = 0;
            Zone43 file43 = new Zone43(new FileInfo("lab8_2.txt"));

            Thread thread1_43 = new Thread(() =>
            {
                for (int i = 0; i < counterStrings; i++)
                {
                    fileLockM.WaitOne();
                    countLines = file43.WriteToFile("M 1 у потоцi 1 рядок " + i);
                    Console.WriteLine("M 1 Прочитано строку \"" + file43.ReadFromFile(countLines) + "\"");
                    fileLockM.ReleaseMutex();
                }
            });
            thread1_43.Start();

            Thread thread2_43 = new Thread(() =>
            {
                for (int i = 0; i < counterStrings; i++)
                {
                    fileLockM.WaitOne();
                    countLines = file43.WriteToFile("M 2 у потоцi 2 рядок " + i);
                    Console.WriteLine("M 2 Прочитано строку \"" + file43.ReadFromFile(countLines) + "\"");
                    fileLockM.ReleaseMutex();
                }
            });
            thread2_43.Start();
            #endregion 4.3
        }
    }
}
