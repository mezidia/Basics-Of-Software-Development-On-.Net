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

			DivideArrays(secondArray, firstArray);

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
				ThrowInner();
			}
			catch (Exception e)
			{
				Console.WriteLine("\nЄ виняток:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}
		}

		public static void DivideArrays(int[] divided, int[] divider)
		{
			Console.WriteLine($"загальна к-сть можливих множень для цих " +
				$"двох масивів = {divided.Length * divider.Length}");
			for (int i = 0; i < divided.Length; i++)
			{
				for (int j = 0; j < divider.Length; j++)
				{
					try
					{
						Console.WriteLine($"{divided[i]} / {divider[j]} = " +
						$"{divided[i] / divider[j]}");
					}
					catch (Exception e)
					{
						Console.WriteLine("\nЄ виняток:");
						Console.WriteLine(e.Message);
						Console.WriteLine(e.GetType());
					}
				}
			}
		}

		public static void ThrowInner()
		{
			throw new Exception("\nВнутрішнє виключення");
		}
	}
}
