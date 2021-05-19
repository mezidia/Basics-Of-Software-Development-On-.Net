﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Additional
{
	public class Additional
	{
		private static Mutex fileLockM = new Mutex();
		static void Main()
		{
			RunAdditional();
			#region Lab8

			#region 4.3
			int counterStrings = 5;
			int countLines = 0;
			Zone43 file43 = new Zone43(new FileInfo("lab8_2.txt"));

			Thread thread1_43 = new Thread(() =>
			{
				for (int i = 0; i < counterStrings; i++)
				{
					fileLockM.WaitOne();
					countLines = file43.WriteToFile("1 у потоцi 1 рядок " + i);
					Console.WriteLine("1 Прочитано строку \"" + file43.ReadFromFile(countLines) + "\"");
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
					Console.WriteLine("2 Прочитано строку \"" + file43.ReadFromFile(countLines) + "\"");
					fileLockM.ReleaseMutex();
				}
			});
			thread2_43.Start();
			#endregion 4.3

			#endregion Lab8
		}

		#region Lab7

		public static void RunAdditional()
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
				Console.WriteLine($"{element} елемент масиву = " + array[element-1]);
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

		
	}
}
