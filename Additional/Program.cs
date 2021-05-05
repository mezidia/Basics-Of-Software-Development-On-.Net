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
			WriteArray("\n\nДругий масив:", secondArray);

			Console.WriteLine("\n\nНамагаємося отримати доступ до 5-ого" +
				" елементу першого масиву\n");

			try
			{
				Console.WriteLine($"5-ий елемент масиву = " + firstArray[4]);
			}
			catch (Exception e)
			{
				Console.WriteLine("Є виняток:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}

			Console.WriteLine("\nНамагаємося отримати доступ до 4-ого" +
				" елементу другого масиву\n");

			try
			{
				Console.WriteLine($"4-ий елемент масиву = " + secondArray[3]);
			}
			catch (Exception e)
			{
				Console.WriteLine("Є виняток:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}

			Console.ReadKey();
		}

		public static void WriteArray(string text, int[] array)
		{
			Console.WriteLine(text);

			foreach (int num in array)
			{
				Console.Write(num + " ");
			}
		}

		public void ThrowInner()
		{
			throw new Exception("Внутрішнє виключення");
		}
	}
}
