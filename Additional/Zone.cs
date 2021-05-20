using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;

namespace Hotel.Project
{
	public class Zone
	{
		#region Lab8-2

		private readonly FileInfo file;
		private static readonly object fileLock = new object();

		public static void Lab8_2()
		{
			Zone file = new Zone(new FileInfo("lab8.txt"));
			int counterStrings = 5;
			int countLines = 0;

			Thread thread1 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					lock (fileLock)
					{
						countLines = file.WriteToFile("1 у" +
							" потоцi 1 рядок " + i);
						Console.WriteLine("1 Прочитано строку" +
							" \"" + file.ReadFromFile(countLines) + "\"");
					}
				}
			});

			thread1.Start();

			Thread thread2 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					lock (fileLock)
					{
						countLines = file.WriteToFile("2 у потоцi" +
							" 2 рядок " + i);
						Console.WriteLine("2 Прочитано строку" +
							" \"" + file.ReadFromFile(countLines) + "\"");
					}
				}
			});

			thread2.Start();
		}

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
				using var sr = new StreamReader(file.FullName);
				for (int i = 1; i < line; i++)
				{
					sr.ReadLine();
				}
				return sr.ReadLine();
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
