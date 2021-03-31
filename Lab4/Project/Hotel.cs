using System;
using System.Collections.Generic;

namespace Hotel
{
	public class Hotel
	{
		private int numberOfStars;

		/// <summary>
		/// We need this to get and set numberOfStars.
		/// Also We check if value isn't null.
		/// </summary>
		public int NumberOfStars
		{
			get
			{
				return numberOfStars;
			}
			set
			{
				if (value.ToString() != null && value >= 1 && value <= 5)
				{
					numberOfStars = value;
				}
				else Console.WriteLine("Введiть правильну кiлькiсть зiрок");
			}
		}

		private string description;

		/// <summary>
		/// We need this to get and set description.
		/// Also We check if value > 20.
		/// </summary>
		public string Description
		{
			get
			{
				return description;
			}
			set
			{
				if (value.Length > 20)
				{
					description = value;
				}
				else Console.WriteLine("Введiть бiльшу кiлькiсть символiв");
			}
		}

		private int rating;

		/// <summary>
		/// We need this to get and set rating.
		/// Also We check if value isn't null.
		/// </summary>
		public int Rating
		{
			get
			{
				return rating;
			}
			set
			{
				if (value.ToString() != null) rating = value;
				else Console.WriteLine("Введiть не пустий iдентифiкатор рейтингу");
			}
		}

		private int hotelID;

		/// <summary>
		/// We need this to get and set hotelID.
		/// Also We check if value isn't null.
		/// </summary>
		public int HotelID
		{
			get
			{
				return hotelID;
			}
			set
			{
				if (value.ToString() != null) hotelID = value;
				else Console.WriteLine("Введiть не пустий iдентифiкатор готелю");
			}
		}

		private string hotelName;

		/// <summary>
		/// We need this to get and set hotelName.
		/// Also We check if value < 15.
		/// </summary>
		public string HotelName
		{
			get
			{
				return hotelName;
			}
			set
			{
				if (value.Length < 15) hotelName = value;
				else Console.WriteLine("Забагато символiв для iменi готелю");
			}
		}

		private string address;

		/// <summary>
		/// We need this to get and set hotelName.
		/// Also We check if value < 15.
		/// </summary>
		public string Address
		{
			get
			{
				return address;
			}
			set
			{
				if (value.Length > 1)
				{
					address = value;
				}
				else
				{
					Console.WriteLine("Невiрна адреса");
				}
			}
		}

		public City City { get; set; }
		public List<Room> Rooms = new List<Room>();
		public List<Order> Orders = new List<Order>();

		public Hotel(int hotelID, string hotelName,
			string address, string description)
		{
			HotelID = hotelID;
			HotelName = hotelName;
			Address = address;
			Description = description;

			// Temp for Composition
			Room FirstRoom = new Room(1, 1, "First", 2,
				this, true, "Big", 5, true);
			Rooms.Add(FirstRoom);
			Console.WriteLine($"Готель {hotelName} створено");
		}

		public void CreateRoom(int roomID, int roomNumber,
			string roomName, int roomSize, Hotel hotel, bool? tv,
			string roomType, int numberOfBeds, bool? balcony)
		{
			Room room = new Room(roomID, roomNumber, roomName,
				roomSize, hotel, tv, roomType, numberOfBeds, balcony);
			Rooms.Add(room);
		}

		/// <summary>
		/// Deletes the room.
		/// </summary>
		/// <param name="room">The room.</param>
		public void DeleteRoom(ref Room room)
		{
			room = null;
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
