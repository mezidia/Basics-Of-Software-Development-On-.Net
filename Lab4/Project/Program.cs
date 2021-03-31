using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			Console.WriteLine("Третя лабораторна робота\n");

			Hotel RedHotel = new Hotel(1, "Адам", "вул. Т. Шевченка",
				"Дуже крутий опис дуже крутого готелю, який всім дуже " +
				"подобається")
			{
				City = City.Kyiv, Rating = 32
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

			#region overloading
			if (RedHotel) Console.WriteLine("Рейтинг додатнiй");
			RedHotel.Rating = -23;
			if (!RedHotel) Console.WriteLine("Рейтинг вiд'ємний");

			if (order) Console.WriteLine("Замовлення ще активне");
			order.DateEnd = DateTime.Parse("22.01.2002");
			if (!order) Console.WriteLine("Замовлення вже не активне");

			if (AdminV) Console.WriteLine("Користувач має пошту та телефон");
			GreatValeera.UserMail = "shemsedinov@gmail.com";
			GreaterValeera.UserMail = "shemsedinov@gmail.com";
			GreatValeera.UserPhone = "+069069696";
			GreaterValeera.UserPhone = "+069069696";
			if (GreatValeera & GreaterValeera)
            {
				Console.WriteLine("Користувачi мають пошту та телефон");
			}

			#endregion overloading

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
