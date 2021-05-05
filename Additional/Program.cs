using System;

namespace Additional
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] firstArray = { 0, 1, 2, 3 };
			int[] secondArray = { 4, 5, 6 };

			Console.WriteLine("Намагаємося отримати доступ до 5-ого" +
				" елементу першого масиву");

			try
			{
				Console.WriteLine($"5-ий елемент масиву = " + firstArray[4]);
			}
			catch (Exception e)
			{
				Console.WriteLine("Catch some exception");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}

			Console.WriteLine("Намагаємося отримати доступ до 4-ого" +
				" елементу другого масиву");

			try
			{
				Console.WriteLine($"4-ий елемент масиву = " + firstArray[3]);
			}
			catch (Exception e)
			{
				Console.WriteLine("Catch some exception");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}
		}
	}
}
