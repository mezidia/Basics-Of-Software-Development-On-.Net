using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			#region Lab1-2-3

			Console.WriteLine("Четверта лабораторна робота\n");

			Hotel RedHotel = new Hotel(1, "Адам", "вул. Т. Шевченка",
				"Дуже крутий опис дуже крутого готелю, який всім дуже " +
				"подобається")
			{
				City = City.Kyiv, Rating = 32, NumberOfStars = 3
			};

			User AdminV = new User(1, 2, "AdminValera", "valera69@gmail.com",
				"+069069696");

			RedHotel.CreateRoom(2, 2, "Red", 1, RedHotel, true, "Big", 5, true);

			RedHotel.CreateOrder(1, 300, RedHotel, AdminV, "1", RedHotel.Rooms[0],
				DateTime.Now, DateTime.Now.AddDays(7));

			Order order = new Order(2, 300, RedHotel, AdminV,
				"2", RedHotel.Rooms[1],
				DateTime.Now, DateTime.Now.AddDays(7))
			{
				DateStart = DateTime.Parse("22.01.2002")
			};

			// Constructor by default
			User GreatValeera = new User
			{
				UserName = "GreatValeera"
			};

			// Copy Constructor
			User GreaterValeera = new User(GreatValeera);

			#endregion Lab1-2-3

			#region Lab4

			Console.WriteLine("\n--------Lab4-------");

			#region Logical

			Console.WriteLine("\n--Перевантаження логiчних операторiв:--\n");

			if (RedHotel) Console.WriteLine("Рейтинг додатнiй");
			RedHotel.Rating = -23;
			if (!RedHotel) Console.WriteLine("Рейтинг вiд'ємний");

			Console.WriteLine();

			if (order) Console.WriteLine("Замовлення ще активне");
			order.DateEnd = DateTime.Parse("22.01.2002");
			if (!order) Console.WriteLine("Замовлення вже не активне");

			Console.WriteLine();

			if (AdminV) Console.WriteLine("Користувач має пошту та телефон");
			GreatValeera.UserMail = "shemsedinov@gmail.com";
			GreaterValeera.UserMail = "shemsedinov@gmail.com";
			GreatValeera.UserPhone = "+069069696";
			GreaterValeera.UserPhone = "+069069696";
			if (GreatValeera & GreaterValeera)
			{
				Console.WriteLine("Користувачi мають пошту та телефон");
			}

			#endregion Logical

			#region Unary

			Console.WriteLine("\n--Перевантаження унарних операторiв:--\n");

			Console.WriteLine($"Кiлькiсть зiрок: {RedHotel.NumberOfStars}");
			++RedHotel;
			Console.WriteLine($"Кiлькiсть зiрок пiсля збiльшення:" +
				$" {RedHotel.NumberOfStars}");
			--RedHotel;
			Console.WriteLine($"Кiлькiсть зiрок пiсля зменшення:" +
				$" {RedHotel.NumberOfStars}");

			Console.WriteLine();

			Console.WriteLine($"Кiлькiсть лiжок: {RedHotel.Rooms[0].NumberOfBeds}");
			++RedHotel.Rooms[0];
			Console.WriteLine($"Кiлькiсть зiрок пiсля збiльшення:" +
				$" {RedHotel.Rooms[0].NumberOfBeds}");
			--RedHotel.Rooms[0];
			Console.WriteLine($"Кiлькiсть зiрок пiсля зменшення:" +
				$" {RedHotel.Rooms[0].NumberOfBeds}");

			#endregion Unary

			#endregion Lab4

			Console.WriteLine("\n--------Credits-------");

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
