﻿using System;
using System.Collections.Generic;
using System.Text;

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
				if (value.ToString() != null && value >= 1 && value <= 5) numberOfStars = value;
				else Console.WriteLine("Введіть правильну кількість зірок.");
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
				if (value.Length() > 20) description = value;
				else Console.WriteLine("Введіть більшу кількість символів");
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
				else Console.WriteLine("Введіть не пустий ідентифікатор рейтингу");
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
				else Console.WriteLine("Введіть не пустий ідентифікатор готелю.");
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
				return hotelname;
            }
			set
            {
				if (value.Length() < 15) hotelName = value;
				else Console.WriteLine("Забагато символів для імені готелю.");
            }
		}
		private string adress;
		/// <summary>
		/// We need this to get and set hotelName.
		/// Also We check if value < 15.
		/// </summary>
		public string Adress 
		{
			get 
			{
				return adress;
			}
			set
            {
				if (value.Length() < 1) adress = value;
				else Console.WriteLine("Невірна адреса");
            }
		}

		public City City { get; set; }
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
