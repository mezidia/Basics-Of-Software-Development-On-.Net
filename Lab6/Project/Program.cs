using Hotel.Project;
using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			#region Lab1-2-3-4-5

			Console.WriteLine("\n--------Lab1-2-3--------");

			Hotel RedHotel = new Hotel(1, "Адам", "вул. Т. Шевченка",
				"Дуже крутий опис дуже крутого готелю, який всім дуже " +
				"подобається")
			{
				City = City.Kyiv,
				Rating = 32,
				NumberOfStars = 3
			};

			User AdminV = new User(1, 2, "AdminValera", "valera69@gmail.com",
				"+069069696");

			RedHotel.CreateRoom(2, 2, "Red", 1, RedHotel, true, "Big", 5, true);

			RedHotel.CreateOrder(1, 300, RedHotel, AdminV, "1", RedHotel.Rooms[0],
				DateTime.Now, DateTime.Now.AddDays(7));

			ConcreteOrder order = new ConcreteOrder(2, 300, RedHotel, AdminV,
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

			#region Lab4

			Console.WriteLine("\n--------Lab4--------");

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

			#region Binary

			Console.WriteLine("\n--Перевантаження бiнарних операторiв:--\n");

			Console.WriteLine("Iм'я першої кiмнати = "
				+ RedHotel.Rooms[0].RoomName);
			Console.WriteLine("Iм'я другої кiмнати = "
				+ RedHotel.Rooms[1].RoomName);

			Console.WriteLine($"Розмiр першої кiмнати = " +
				$"{RedHotel.Rooms[0].RoomSize}\nРозмiр другої " +
				$"кiмнати = {RedHotel.Rooms[1].RoomSize}\n");

			Room newRoom = RedHotel.Rooms[0] + RedHotel.Rooms[1];

			Console.WriteLine("Iм'я нової першої кiмнати = "
				+ RedHotel.Rooms[0].RoomName);

			Console.WriteLine($"Розмiр нової, об'єднаної кiмнати = " +
				$"{newRoom.RoomSize}");

			#endregion Binary

			#region Logical

			Console.WriteLine("\n--Перевантаження логiчних операторiв:--\n");

			if (RedHotel) Console.WriteLine("Рейтинг додатнiй");
			RedHotel.Rating = 23;
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

			#region Comparison

			Console.WriteLine("\n--Перевантаження операторiв порiвняння:--\n");

			Hotel BlueHotel = new Hotel(2, "Єва", "вул. Т. Шевченка",
				"Не дуже крутий опис не дуже крутого готелю, який не всiм не дуже " +
				"не подобається")
			{
				City = City.Kyiv,
				Rating = 32,
				NumberOfStars = 3
			};

			BlueHotel.CreateRoom(2, 2, "Blue", 5, BlueHotel, false, "Big", 15, true);

			Console.WriteLine($"Кiлькiсть зiрок, рейтинг Готелю " +
				$"1: {RedHotel.NumberOfStars}, {RedHotel.Rating}");
			Console.WriteLine($"Кiлькiсть зiрок, рейтинг Готелю " +
				$"2: {BlueHotel.NumberOfStars}, {BlueHotel.Rating}");

			Console.WriteLine($"Перевiряємо рiвнозначнiсть Готелю 1 " +
				$"та Готелю 2: {RedHotel == BlueHotel}");
			Console.WriteLine($"Перевiряємо нерiвнозначнiсть Готелю 1 " +
				$"та Готелю 2: {RedHotel != BlueHotel}");
			Console.WriteLine();

			Console.WriteLine($"Кiлькiсть лiжок, розмiр, наявнiсть" +
				$" телевiзора та балкону в Кiмнатi 1: " +
				$"{RedHotel.Rooms[0].NumberOfBeds}, " +
				$"{RedHotel.Rooms[0].RoomSize}, {RedHotel.Rooms[0].TV}," +
				$" {RedHotel.Rooms[0].Balcony}");
			Console.WriteLine($"Кiлькiсть лiжок, розмiр, наявнiсть" +
				$" телевiзора та балкону в Кiмнатi 2: " +
				$"{BlueHotel.Rooms[0].NumberOfBeds}, " +
				$"{BlueHotel.Rooms[0].RoomSize}, {BlueHotel.Rooms[0].TV}, " +
				$"{BlueHotel.Rooms[0].Balcony}");

			Console.WriteLine($"Перевiряємо рiвнозначнiсть Кiмнати 1 та " +
				$"Кiмнати 2: {RedHotel.Rooms[0] == BlueHotel.Rooms[0]}");
			Console.WriteLine($"Перевiряємо нерiвнозначнiсть Кiмнати 1 та " +
				$"Кiмнати 2: {RedHotel.Rooms[0] != BlueHotel.Rooms[0]}");

			#endregion Comparison

			#endregion Lab4

			#region Lab5

			Console.WriteLine("\n--------Lab5--------");

			#region Base-Classes-And-Inheritence

			Console.WriteLine("\n--Базовi та похiднi класи:--");

			Console.WriteLine("\nСтворюємо вiдвiдувача:");
			Customer Customer = new Customer(7,
				"customer@gmail.com", "Genji", "+067069696");

			Console.WriteLine("\nСтворюємо адмiна:");
			Admin Admin = new Admin(8, "admin@gmail.com",
				"Hanzo", "+069069698");

			#endregion Base-Classes-And-Inheritence

			#region Abstract-Classes-And-Virtual-Methods

			Console.WriteLine("\n--Абстрактнi класи та вiртуальнi методи:--");

			Console.WriteLine("\nВикористовуємо перший override конструктор:");

			NotSoConcreteOrder NotSoConcreteOrder = new NotSoConcreteOrder(50,
				666, BlueHotel, Admin, "3", BlueHotel.Rooms[0],
				DateTime.Now, DateTime.Now.AddDays(7));

			Console.WriteLine("\nВикористовуємо другий override конструктор:");

			ConcreteOrder ConcreteOrder = new ConcreteOrder(51,
				667, BlueHotel, Customer, "4", BlueHotel.Rooms[1],
				DateTime.Now, DateTime.Now.AddDays(7));

			Console.WriteLine("\nВикористовуємо перший override метод:");

			NotSoConcreteOrder.IsExpired();

			Console.WriteLine("\nВикористовуємо перший не override метод:");

			ConcreteOrder.IsExpired();

			Console.WriteLine("\nВикористовуємо другий override метод:");

			NotSoConcreteOrder.BelongsTo();

			Console.WriteLine("\nВикористовуємо другий не override метод:");

			ConcreteOrder.BelongsTo();

			#endregion Abstract-Classes-And-Virtual-Methods

			#region Interface

			Console.WriteLine("\n--Iнтерфейси:--");

			Console.WriteLine("\nСтворюємо готель через iнтерфейс:");

			IRoom greenHotel = new Hotel(4, "GreenDeer", "вул. Т. Шевченка",
				"Myyyyyyyyyyyyyyyyy Myyyyyyyyyyyyyyyyy " +
				"Myyyyyyyyyyyyyyyyy Myyyyyyyyyyyyyyyyy Myyyyyyyyyyyyyyyyy")
			{
				City = City.Kyiv,
				Rating = 12,
				NumberOfStars = 5
			};

			greenHotel.CreateRoom(2, 2, "aZUL", 1, (Hotel)greenHotel
				/*Downcasting*/, true, "Big", 5, true);

			#endregion Interface

			#region Upcast, Downcast

			Console.WriteLine("\n--Upcast та Downcast:--");

			// Upcast
			Customer customer = new Customer(7,
				"customer@gmail.com", "Genji", "+067069696");
			Admin admin = new Admin(8,
				"admin@gmail.com", "Hanzo", "+069069698");

			User customerUser = customer;
			User adminUser = admin;

			Console.WriteLine("\n--Показуємо типи об'єктiв" +
				" пiсля Upcast:--");

			Console.WriteLine(customerUser.GetType());
			Console.WriteLine(adminUser.GetType());
			Customer customer1 = (Customer)customerUser;
			Admin admin1 = (Admin)adminUser;

			Console.WriteLine("\n--Показуємо властивостi " +
				"об'єктiв пiсля Downcast:--");

			Console.WriteLine(customer1.UserTypeName);
			Console.WriteLine(admin1.UserTypeName);

			#endregion Upcast, Downcast

			#endregion Lab5

			#endregion Lab1-2-3-4-5

			#region Lab6

			#region anonymous-methods
			Console.WriteLine("Приклади використання анонiмних методiв:");
			Room.ShowMessage("1. Анонiмний метод класу Room!", delegate(string mes) 
				{ 
					Console.WriteLine(mes); 
				});

			#endregion anonymous-methods

			#endregion Lab6

			Console.WriteLine("\n--------Credits-------");

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim," +
				"\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");

			Console.ReadLine();
		}
	}
}
