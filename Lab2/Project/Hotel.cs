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
			Room FirstRoom = new Room(1, "First", 1, HotelID, 100);
			Rooms.Add(FirstRoom);
			Console.WriteLine("Hotel is Created");
		}

		public void CreateRoom(int ID, string name,
			int size, int hotelID, decimal price)
		{
			Room room = new Room(ID, name, size, hotelID, price);
			Rooms.Add(room);
		}

		public void CreateOrder(int OrderID, decimal Sum,
			Hotel Hotel, User User, string OrderNumber)
		{
			Order order = new Order(OrderID, Sum, Hotel,
				User, OrderNumber);
			User.Orders.Add(order);
			Hotel.Orders.Add(order);
		}
	}
}
