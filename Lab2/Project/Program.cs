﻿using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			Console.WriteLine("Second Lab has started\n");

			Hotel RedHotel = new Hotel(1, "Адам", "вул. Т. Шевченка", "Something")
			{
				city = City.Kyiv
			};

			User AdminV = new User(1, 2, "AdminValera", "valera69@gmail.com",
				"+0690696969");

			RedHotel.CreateRoom(2, "Red", 1, RedHotel.hotelID, 200);

			RedHotel.CreateOrder(1, 300, RedHotel, AdminV, "1", RedHotel.rooms[0],
				DateTime.Now, DateTime.Now.AddDays(7));

			// Constructor by default
			User GreatValeera = new User();

			// Copy Constructor
			User GreaterValeera = new User(GreatValeera);

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
