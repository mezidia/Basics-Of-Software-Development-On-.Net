using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Hotel
	{
		public int NumberOfStars;
		public string Description;
		public int RatingInt;
		public int HotelID { get; set; }
		public string HotelName { get; set; }
		public City City { get; set; }
		public string Adress { get; set; }
		public List<Room> Rooms = new List<Room>();
		public List<Order> Orders = new List<Order>();

		public Hotel(int HotelID, string HotelName,
			string Adress, string Description)
		{
			this.HotelID = HotelID;
			this.HotelName = HotelName;
			this.Adress = Adress;
			this.Description = Description;

			// Temp for Composition
			Room FirstRoom = new Room(1, 1, "First", 1, this, true, "Big", 5, true);
			Rooms.Add(FirstRoom);
			Console.WriteLine("Hotel is Created");
		}

		public void CreateRoom(int roomID, int roomNumber, string roomName, int roomSize, Hotel hotel, bool? tv,
			string roomType, int numberOfBeds, bool? balcony)

		{
			Room room = new Room(roomID, roomNumber, roomName, roomSize, hotel, tv, roomType, numberOfBeds, balcony);
			Rooms.Add(room);
		}

		public void CreateOrder(int OrderID, decimal Sum,
			Hotel Hotel, User User, string OrderNumber,
			Room Room, DateTime Start, DateTime End)
		{
			Order order = new Order(OrderID, Sum, Hotel,
				User, OrderNumber, Room, Start, End);
			User.Orders.Add(order);
			Hotel.Orders.Add(order);
		}
	}
}
