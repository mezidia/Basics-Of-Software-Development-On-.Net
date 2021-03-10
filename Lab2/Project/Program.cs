using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			Console.WriteLine("Second Lab has started");
			User AdminV = new User(1, 2, "AdminValera", "valera69@gmail.com",
				"+0690696969");
			AdminV.AddHotel(1, "Адам", "вул. Т. Шевченка", City.Kyiv);
			
			Console.WriteLine("First Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
