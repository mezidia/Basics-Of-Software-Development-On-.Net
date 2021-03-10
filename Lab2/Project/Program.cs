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
			Hotel RedHotel = new Hotel(1, "Адам", "вул. Т. Шевченка", "Something")
			{
				City = City.Kyiv
			};

			RedHotel.CreateRoom(2, "Red", 1, RedHotel.HotelID, 200);

			RedHotel.CreateOrder(1, 300, RedHotel, AdminV, "1");

			Console.WriteLine("First Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
