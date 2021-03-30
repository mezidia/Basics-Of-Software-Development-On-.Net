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
				City = City.Kyiv
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

			Console.WriteLine("Ім'я першої кімнати = "
				+ RedHotel.Rooms[0].RoomName);
			Console.WriteLine("Ім'я другої кімнати = "
				+ RedHotel.Rooms[1].RoomName);

			Room newRoom = RedHotel.Rooms[0] + RedHotel.Rooms[1];

			Console.WriteLine("Ім'я нової першої кімнати = "
				+ RedHotel.Rooms[0].RoomName);

			Console.WriteLine($"Size of the first room is " +
				$"{RedHotel.Rooms[0].RoomSize},\nSize of the" +
				$" second room is {RedHotel.Rooms[1].RoomSize},\n" +
				$"And Size of the new combined room is " +
				$"{newRoom.RoomSize}");

			#endregion overloading

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
