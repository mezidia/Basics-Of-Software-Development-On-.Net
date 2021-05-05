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

			GetAccess(firstArray, 5);
			GetAccess(secondArray, 4);

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

		public static void GetAccess(int[] array, int element)
		{
			try
			{
				Console.WriteLine($"{element} елемент масиву = " + array[element-1]);
			}
			catch (Exception e)
			{
				Console.WriteLine("Є виняток:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.GetType());
			}
		}

		public void ThrowInner()
		{
			throw new Exception("Внутрішнє виключення");
		}
	}
}
