using Hotel.Project;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Hotel
{
	/// <summary>
	/// Main class of Our project, where all magic happens
	/// </summary>
	class MainClass
	{
		static void Main()
		{
			#region Lab1-2-3-4-5-6-7
			/*
			#region Lab1-2-3

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

			#endregion Lab1-2-3

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
				, true, "Big", 5, true); // Downcasting

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

			#region Lab6

			Console.WriteLine("\n--------Lab6--------");

			#region Events

			Console.WriteLine("\n--Подiї:--\n");

			Hotel EventHotel = new Hotel(56, "Подiя", "вул. Т. Шевченка",
				"Дуже крутий опис дуже крутого готелю, який всім дуже " +
				"подобається")
			{
				City = City.Kyiv,
				Rating = 35,
				NumberOfStars = 4
			};

			EventHotel.EventForNotifying += DisplayMessage;

			EventHotel.CreateRoom(2, 2, "Подiя", 1, EventHotel, true, "Big", 5, true);

			#endregion Events

			#region Anonymous-Methods

			Console.WriteLine("\n--Анонiмнi методи:--\n");

			Room.ShowSomeString("1. Анонiмний метод класу Room.", delegate (string messageString)
			{
				Console.WriteLine(messageString);
			});

			Hotel.ShowSomeString("2. Анонiмний метод класу Hotel.", delegate (string messageString)
			{
				Console.WriteLine(messageString);
			});

			#endregion Anonymous-Methods

			#region Lambda

			Console.WriteLine("\n--Лямбди:--\n");

			Console.WriteLine("Коефiцiєнт просторностi кiмнати: "
				+ RedHotel.Rooms[0].SpaceKoeff);

			RedHotel.Rooms[0].CheckHotelPrice(x => DateTime.Now.DayOfWeek
			!= DayOfWeek.Sunday);

			decimal priceOne()
			{
				return order.Room.NumberOfBeds == 0 ? 1
					: order.Sum / order.Room.NumberOfBeds;
			}

			Console.WriteLine("Цiна за одну людину в кiмнатi: " + priceOne());

			#endregion Lambda

			#endregion Lab6

			#region Lab7

			Console.WriteLine("\n--------Lab7--------");

			#region Authorization

			Console.WriteLine("\n--Винятки авторизацiї:--\n");

			AdminV.Login = "Valera96";
			AdminV.Password = "Valerchikperchik69";

			//обробка неправильного логіну
			ShowAuthException(AdminV, "Valera9", "Valerchikperchik6");

			//обробка пустого паролю
			ShowAuthException(AdminV, "Valera96", "");

			//обробка пустого логіну
			ShowAuthException(AdminV, "", "Valerchikperchik69");

			//коректний логін
			ShowAuthException(AdminV, "Valera96", "Valerchikperchik69");

			#endregion Authorization

			#region Filters-And-Arrays

			Console.WriteLine("\n--Робота з фiльтрами та масивами:--\n");

			Additional.Additional.Lab7();

			#endregion Filters-And-Arrays

			#region SystemExceptions

			Console.WriteLine("\n--Системнi винятки:--\n");

			object stacks = "twelve";
			List<User> users = null;
			var users2 = new List<string>();

			// InvalidCastException
			try
			{
				int KelThuzad = (int)stacks;
				Console.WriteLine("Cast is success");
			}
			catch (InvalidCastException)
			{
				Console.WriteLine("Catched casting exception");
			}

			// ArgumentException
			try
			{
				if (stacks != "+069069698")
				{
					throw new ArgumentException();
				}
				Console.WriteLine("Argument is good");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("Catched argument exception");
			}

			// NullReferenceException
			try
			{
				users.Add(GreatValeera);
			}
			catch (NullReferenceException)
			{
				Console.WriteLine("Catched null reference exception");
			}

			// ArgumentOutOfRangeException
			try
			{
				Console.WriteLine("The first item: '{0}'", users2[0]);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Catched argument out of range exception");
			}

			#endregion SystemExceptions

			#region CustomExceptions

			Console.WriteLine("\n--Власнi винятки:--\n");

			try
			{
				throw new Metaclass();
			}
			catch (Metaclass e)
			{
				Console.WriteLine("Обработка исключения:");
				e.MetaMethod();
			}

			#endregion CustomExceptions

			#endregion Lab7
			*/
			#endregion Lab1-2-3-4-5-6-7

			#region Lab8

			Console.WriteLine("\n--------Lab8--------");

			#region Lab8-1

			Console.WriteLine("\n--4.1:--\n");

			DateTime startTime1 = DateTime.Now;
			Additional.Additional.Count1();
			DateTime endTime1 = DateTime.Now;
			TimeSpan diff1 = endTime1 - startTime1;

			Console.WriteLine("Час виконання (один потiк):");
			Console.WriteLine(diff1.TotalMilliseconds);

			DateTime startTime2 = DateTime.Now;
			Additional.Additional.First().Start();
			DateTime endTime3 = DateTime.Now;
			Additional.Additional.Second().Start();
			DateTime endTime4 = DateTime.Now;

			TimeSpan diff2 = endTime3 - startTime2;
			TimeSpan diff4 = endTime4 - endTime3;
			TimeSpan totalDiff = endTime4 - startTime2;

			Console.WriteLine($"Час виконання (окремi потоки): " +
				$"\n{diff2.TotalMilliseconds}" +
				$"\n{diff4.TotalMilliseconds} \nЗагальний " +
				$"час - {totalDiff.TotalMilliseconds}");

			#endregion Lab8-1

			#region Lab8-2

			Console.WriteLine("\n--4.2:--\n");

			Zone.Lab8_2();

			Thread.Sleep(1000);

			#endregion Lab8-2

			#region Lab8-3

			Console.WriteLine("\n--4.3:--\n");

			Additional.Additional.Lab8_3();

			Thread.Sleep(1000);

			#endregion Lab8-3

			#region Lab8-4

			Console.WriteLine("\n--4.4:--\n");

			Additional.Additional.Lab8_4();

			Thread.Sleep(1000);

			#endregion Lab8-4

			#endregion Lab8

			Console.WriteLine("\n--------Credits-------");

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim," +
				"\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");

			Console.ReadLine();
		}

		private static void ShowAuthException(User AdminV, string login, string password)
		{
			try
			{
				AdminV.LogIn(login, password);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (LogInException e)
			{
				Console.WriteLine(e.Message);
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}

		/// <summary>
		/// Method for delegate to print some message
		/// </summary>
		/// <param name="message"></param>
		private static void DisplayMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}
