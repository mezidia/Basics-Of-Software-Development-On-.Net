using System;
namespace Hotel
{
	class MainClass
	{
		static void Main()
		{
			Console.WriteLine("Четверта лабораторна робота\n");

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

			Console.WriteLine("\nПеревантаження\n");

			Console.WriteLine("Iм'я першої кiмнати = "
				+ RedHotel.Rooms[0].RoomName);
			Console.WriteLine("Iм'я другої кiмнати = "
				+ RedHotel.Rooms[1].RoomName);

			Console.WriteLine($"Розмiр першої кiмнати = " +
				$"{RedHotel.Rooms[0].RoomSize},\nРозмiр другої " +
				$"кiмнати = {RedHotel.Rooms[1].RoomSize},\n");

			Room newRoom = RedHotel.Rooms[0] + RedHotel.Rooms[1];

			Console.WriteLine("Iм'я нової першої кiмнати = "
				+ RedHotel.Rooms[0].RoomName);

			Console.WriteLine($"Та розмiр нової, об'єднаної кiмнати " +
				$"{newRoom.RoomSize}");

			Console.WriteLine();

			RedHotel.DeleteItself(ref RedHotel);

			#endregion overloading

			Console.WriteLine("\nFirst Team: Zavalniuk Maxim,\nDmytrenko Roman,\n" +
				"Sichkar Tetiana,\nDominskyi Valentyn");
			Console.ReadLine();
		}
	}
}
