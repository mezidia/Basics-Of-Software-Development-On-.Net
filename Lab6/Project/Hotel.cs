﻿using Hotel.Project;
using System;
using System.Collections.Generic;

namespace Hotel
{
	public class Hotel : IOrder, IRoom
	{
		delegate void Message(string text);
		private static void ShowMessage(string text)
		{
			Console.WriteLine(text);
		}
		Message Dlg = ShowMessage;

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
				else Dlg("Введiть правильну кiлькiсть зiрок");
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
				else Dlg("Введiть бiльшу кiлькiсть символiв");
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
				else Dlg("Введiть не пустий iдентифiкатор рейтингу");
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
				else Dlg("Введiть не пустий iдентифiкатор готелю");
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
				else Dlg("Забагато символiв для iменi готелю");
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
					Dlg("Невiрна адреса");
				}
			}
		}

		// Перевантажуємо логічний оператор !
		public static bool operator !(Hotel hotel)
		{
			if (hotel.Rating > 0)
				return false;
			return true;
		}

		// Перевантажуємо оператор true
		public static bool operator true(Hotel hotel)
		{
			if (hotel.Rating > 0)
				return true;
			return false;
		}

		// Перевантажуємо оператор false
		public static bool operator false(Hotel hotel)
		{
			if (hotel.Rating > 0)
				return false;
			return true;
		}

		public City City { get; set; }
		public List<Room> Rooms = new List<Room>();
		public List<ConcreteOrder> Orders = new List<ConcreteOrder>();

		public delegate void HotelHandler(string messageString);
		public event HotelHandler EventForNotifying;

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

			Dlg($"Готель {hotelName} створено");
		}

		public void CreateRoom(int roomID, int roomNumber,
			string roomName, int roomSize, Hotel hotel, bool? tv,
			string roomType, int numberOfBeds, bool? balcony)
		{
			Room room = new Room(roomID, roomNumber, roomName,
				roomSize, hotel, tv, roomType, numberOfBeds, balcony);
			Rooms.Add(room);

			EventForNotifying?.Invoke($"Додано кiмнату номер {room.RoomNumber} готелю " +
				$"{room.Hotel.HotelName} вiд подiї");
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
			ConcreteOrder order = new ConcreteOrder(OrderID, Sum, Hotel,
				User, OrderNumber, Room, Start, End);
			User.Orders.Add(order);
			Hotel.Orders.Add(order);
		}

		/// <summary>
		/// Implements the operator ++.
		/// </summary>
		/// <param name="h">The hotel.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static Hotel operator ++(Hotel h)
		{
			h.NumberOfStars++;
			return h;
		}

		/// <summary>
		/// Implements the operator --.
		/// </summary>
		/// <param name="h">The hotel.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static Hotel operator --(Hotel h)
		{
			h.NumberOfStars--;
			return h;
		}

		/// <summary>
		/// Implements the operator ==.
		/// </summary>
		/// <param name="h1">The 1 hotel.</param>
		/// <param name="h2">The 2 hotel.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator ==(Hotel h1, Hotel h2)
		{
			// If parameter is null, return false.
			if (h1 is null || h2 is null)
			{
				return false;
			}

			// Optimization for a common success case.
			if (ReferenceEquals(h1, h2))
			{
				return true;
			}

			// If run-time types are not exactly the same, return false.
			if (h1.GetType() != h2.GetType())
			{
				return false;
			}

			// Return true if the fields match.
			return (h1.NumberOfStars == h2.NumberOfStars)
				&& (h1.Rating == h2.Rating);
		}

		/// <summary>
		/// Implements the operator !=.
		/// </summary>
		/// <param name="h1">The 1 hotel.</param>
		/// <param name="h2">The 2 hotel.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator !=(Hotel h1, Hotel h2)
		{
			// If parameter is null, return true.
			if (!(h1 is null) && !(h2 is null))
			{
				// Optimization for a common success case.
				if (ReferenceEquals(h1, h2))
				{
					return false;
				}

				// If run-time types are not exactly the same, return true.
				if (h1.GetType() != h2.GetType())
				{
					return true;
				}

				// Return true if the fields match.
				return !((h1.NumberOfStars == h2.NumberOfStars)
					&& (h1.Rating == h2.Rating));
			}
			return true;
		}

		public delegate void MessageHandler(string messageString);

		public static void ShowSomeString(string messageString, MessageHandler handler)
		{
			handler(messageString);
		}
	}
}
