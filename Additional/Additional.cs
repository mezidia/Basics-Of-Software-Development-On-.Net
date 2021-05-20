using System;
using System.IO;
using System.Threading;

namespace Additional
{
	public class Additional
	{
		private static readonly Mutex fileLockM = new Mutex();
		private static readonly Semaphore fileLockS = new Semaphore(2, 5);

		static void Main()
		{
			Lab7();
			Lab8_3();
		}

		#region Lab7

		public static void Lab7()
		{
			int[] firstArray = { 0, 1, 2, 3 };
			int[] secondArray = { 4, 5, 6 };

			WriteArray("Перший масив:", firstArray);
			WriteArray("Другий масив:", secondArray);

			GetAccess(firstArray, 5, "firstArray");
			GetAccess(secondArray, 4, "secondArray");

			DivideArrays(secondArray, firstArray, false);
			DivideArrays(secondArray, firstArray, true);
		}

		/// <summary>
		/// Write array
		/// </summary>
		/// <param name="text"></param>
		/// <param name="array"></param>
		public static void WriteArray(string text, int[] array)
		{
			Console.WriteLine(text);

			foreach (int num in array)
			{
				Console.Write(num + " ");
			}

			Console.WriteLine("\n");
		}

		/// <summary>
		/// Get access to specific element of an array
		/// </summary>
		/// <param name="array"></param>
		/// <param name="element"></param>
		/// <param name="name"></param>
		public static void GetAccess(int[] array, int element, string name)
		{
			Console.WriteLine($"\nНамагаємося отримати доступ до {element}" +
				$" елементу масиву {name}");

			try
			{
				Console.WriteLine($"{element} елемент масиву = " + array[element - 1]);
			}
			catch (Exception e)
			{
				Console.WriteLine("\nЄ виняток:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}
		}

		/// <summary>
		/// Divide every element of a divided array by divider array
		/// </summary>
		/// <param name="divided"></param>
		/// <param name="divider"></param>
		/// <param name="toCatch"></param>
		public static void DivideArrays(int[] divided, int[] divider, bool toCatch)
		{
			Console.WriteLine($"\nЗагальна к-сть можливих дiлень для цих " +
				$"двох масивiв = {divided.Length * divider.Length}");

			for (int i = 0; i < divided.Length; i++)
			{
				for (int j = 0; j < divider.Length; j++)
				{
					Console.Write($"\n{divided[i]} / {divider[j]} = ");

					try
					{
						Console.Write($"{divided[i] / divider[j]}");
						if (toCatch)
						{
							CatchInner();
						}
					}
					catch (DivideByZeroException e) when (divider[j] == 0)
					{
						Console.Write(e.Message);
					}
					catch (Exception e)
					{
						Console.Write(" Виняток:");
						Console.Write(e.Message);
					}
				}
				Console.WriteLine();
			}
		}

		/// <summary>
		/// Inner exception
		/// </summary>
		public static void ThrowInner()
		{
			throw new DivideByZeroException("Внутрiшнiй виняток при дiленнi на нуль:");
		}

		/// <summary>
		/// Catch inner exception
		/// </summary>
		public static void CatchInner()
		{
			try
			{
				ThrowInner();
			}
			catch (Exception e)
			{
				throw new Exception("Зовнiшнiй виняток при дiленнi на нуль", e);
			}
		}

		#endregion Lab7

		#region Lab8-1

		public static void Count1()
		{
			double res1 = 0;
			for (double i = 1; i <= 100000000; i++)
			{
				res1 = i * (1 + i) / 2;
			}

			//double res2 = 0;
			//for (double i = 1; i <= 100000000; i++)
			//{
			//	res2 = i * (1 + i) / 2;
			//}

			//double res3 = 0;
			//for (double i = 1; i <= 100000000; i++)
			//{
			//	res3 = i * (1 + i) / 2;
			//}
		}

		public static void Count2()
		{
			double res1 = 0;
			for (double i = 1; i <= 100000000; i++)
			{
				res1 = i * (1 + i) / 2;
			}
		}

		public static Thread First()
		{
			return new Thread(new ThreadStart(Count2));
		}

		public static Thread Second()
		{
			return new Thread(new ThreadStart(Count2));
		}

		#endregion Lab8-1

		#region Lab8-3

		public static void Lab8_3()
		{
			int counterStrings = 5;
			int countLines = 0;
			Zone43 file43 = new Zone43(new FileInfo("lab8_2.txt"));

			Thread thread1_43 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockM.WaitOne();
					countLines = file43.WriteToFile("1 у потоцi 1 рядок " + i);
					Console.WriteLine("1 Прочитано строку \""
						+ file43.ReadFromFile(countLines) + "\"");
					fileLockM.ReleaseMutex();
				}
			});

			thread1_43.Start();

			Thread thread2_43 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockM.WaitOne();
					countLines = file43.WriteToFile("2 у потоцi 2 рядок " + i);
					Console.WriteLine("2 Прочитано строку \""
						+ file43.ReadFromFile(countLines) + "\"");
					fileLockM.ReleaseMutex();
				}
			});

			thread2_43.Start();
		}

		#endregion Lab8-3

		#region Lab8-4

		public static void Lab8_4()
		{
			int counterStrings = 5;
			int countLines = 0;
			Zone44 file44 = new Zone44(new FileInfo("lab8_2.txt"));

			Thread thread1_44 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockS.WaitOne();

					countLines = file44.WriteToFile("1 у потоцi 1 рядок " + i);
					Console.WriteLine("1 Прочитано строку \""
						+ file44.ReadFromFile(countLines) + "\"");

					fileLockS.Release();
				}
			});

			thread1_44.Start();

			Thread thread2_44 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockS.WaitOne();

					countLines = file44.WriteToFile("2 у потоцi 2 рядок " + i);
					Console.WriteLine("2 Прочитано строку \""
						+ file44.ReadFromFile(countLines) + "\"");

					fileLockS.Release();
				}
			});

			thread2_44.Start();

			Thread thread3_44 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockS.WaitOne();

					countLines = file44.WriteToFile("3 у потоцi 3 рядок " + i);
					Console.WriteLine("3 Прочитано строку \""
						+ file44.ReadFromFile(countLines) + "\"");

					fileLockS.Release();
				}
			});

			thread3_44.Start();

			Thread thread4_44 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockS.WaitOne();

					countLines = file44.WriteToFile("4 у потоцi 4 рядок " + i);
					Console.WriteLine("4 Прочитано строку \""
						+ file44.ReadFromFile(countLines) + "\"");

					fileLockS.Release();
				}
			});

			thread4_44.Start();

			Thread thread5_44 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockS.WaitOne();

					countLines = file44.WriteToFile("5 у потоцi 5 рядок " + i);
					Console.WriteLine("5 Прочитано строку \""
						+ file44.ReadFromFile(countLines) + "\"");

					fileLockS.Release();
				}
			});

			thread5_44.Start();
		}

		#endregion Lab8-4
	}
}
