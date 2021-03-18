using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Hotel
	{
		public int numberOfStars;
		public string description;
		public int ratingInt;
		public int hotelID;
		public string hotelName;
		public City city;
		public string address;
		public List<Room> rooms = new List<Room>();
		public List<Order> orders = new List<Order>();

		public Hotel(int HotelID, string HotelName,
			string Adress, string Description)
		{
			hotelID = HotelID;
			hotelName = HotelName;
			address = Adress;
			description = Description;

			// Temp for Composition
			Room FirstRoom = new Room(1, "First", 1, HotelID, 100);
			rooms.Add(FirstRoom);
			Console.WriteLine("Hotel is Created");
		}

		public void CreateRoom(int ID, string name,
			int size, int hotelID, decimal price)
		{
			Room room = new Room(ID, name, size, hotelID, price);
			rooms.Add(room);
		}

		public void CreateOrder(int OrderID, decimal Sum,
			Hotel Hotel, User User, string OrderNumber,
			Room Room, DateTime Start, DateTime End)
		{
			Order order = new Order(OrderID, Sum, Hotel,
				User, OrderNumber, Room, Start, End);
			User.orders.Add(order);
			Hotel.orders.Add(order);
		}
	}
}
