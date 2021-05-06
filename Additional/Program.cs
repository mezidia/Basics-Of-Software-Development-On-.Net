using System;

namespace Additional
{
	class Program
	{
		static void Main()
		{
			int[] firstArray = { 0, 1, 2, 3 };
			int[] secondArray = { 4, 5, 6 };

			WriteArray("Перший масив:", firstArray);
			WriteArray("Другий масив:", secondArray);

			GetAccess(firstArray, 5, "firstArray");
			GetAccess(secondArray, 4, "secondArray");

			DivideArrays(secondArray, firstArray, false);
			DivideArrays(secondArray, firstArray, true);

			Console.ReadKey();
		}

		public static void WriteArray(string text, int[] array)
		{
			Console.WriteLine(text);

			foreach (int num in array)
			{
				Console.Write(num + " ");
			}

			Console.WriteLine("\n");
		}

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

		public static void ThrowInner()
		{
			throw new DivideByZeroException("Внутрiшнiй виняток при дiленнi на нуль:");
		}

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
	}
}
