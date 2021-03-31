using System;

namespace Hotel
{
	public class Room
	{
		private int roomID;

		/// <summary>
		/// get and set roomID
		/// check if value is positive
		/// </summary>
		public int RoomID
		{
			get
			{
				return roomID;
			}
			set
			{
				if (value > 0)
				{
					roomID = value;
				}
				else
				{
					Console.WriteLine("ID має бути бiльшим вiд 0");
				}
			}
		}

		private int roomNumber;

		/// <summary>
		/// get and set roomNumber
		/// check if value is positive
		/// </summary>
		public int RoomNumber
		{
			get
			{
				return roomNumber;
			}
			set
			{
				if (value > 0)
				{
					roomNumber = value;
				}
				else
				{
					Console.WriteLine("Номер кiмнати має бути бiльшим від 0");
				}
			}
		}

		private string roomName;

		/// <summary>
		/// get and set roomName
		/// check if value is not empty
		/// </summary>
		public string RoomName
		{
			get
			{
				return roomName;
			}
			set
			{
				if (!string.IsNullOrEmpty(value) &&
					!string.IsNullOrWhiteSpace(value))
				{
					roomName = value;
				}
				else
				{
					Console.WriteLine("Назва кiмнати не повинна бути пустою");
				}
			}
		}

		private int roomSize;

		/// <summary>
		/// get and set roomSize
		/// check if value is positive
		/// </summary>
		public int RoomSize
		{
			get
			{
				return roomSize;
			}
			set
			{
				if (value > 0)
				{
					roomSize = value;
				}
				else
				{
					Console.WriteLine("Розмiр кiмнати має бути бiльшим вiд 0");
				}
			}
		}

		private Hotel hotel;

		/// <summary>
		/// get and set Hotel
		/// check if value is not empty
		/// </summary>
		public Hotel Hotel
		{
			get
			{
				return hotel;
			}
			set
			{
				if (value != null)
				{
					hotel = value;
				}
				else
				{
					Console.WriteLine("Кiмната має належати до готелю");
				}
			}
		}

		private bool? tv;

		/// <summary>
		/// get and set TV
		/// check if value is not empty
		/// </summary>
		public bool? TV
		{
			get
			{
				return tv;
			}
			set
			{
				if (value.HasValue)
				{
					tv = value;
				}
				else
				{
					Console.WriteLine("Введiть значення про наявнiсть телевiзора");
				}
			}
		}

		private string roomType;

		/// <summary>
		/// get and set roomType
		/// check if value is not empty
		/// </summary>
		public string RoomType
		{
			get
			{
				return roomType;
			}
			set
			{
				if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
				{
					roomType = value;
				}
				else
				{
					Console.WriteLine("Задайте тип кiмнати");
				}
			}
		}

		private int numberOfBeds;

		/// <summary>
		/// get and set numberOfBeds
		/// check if value is positive
		/// </summary>
		public int NumberOfBeds
		{
			get
			{
				return numberOfBeds;
			}
			set
			{
				if (value > 0)
				{
					numberOfBeds = value;
				}
				else
				{
					Console.WriteLine("Кiлькість спальних мiсць " +
						"має бути бiльша вiд 0");
				}
			}
		}

		private bool? balcony;

		/// <summary>
		/// get and set balcony
		/// check if value is not empty
		/// </summary>
		public bool? Balcony
		{
			get
			{
				return balcony;
			}
			set
			{
				if (value.HasValue)
				{
					balcony = value;
				}
				else
				{
					Console.WriteLine("Введiть значення про наявнiсть балкону");
				}
			}
		}

		// Перевантажуємо логічний оператор &
		public static bool operator &(Room room1, Room room2)
		{
			if (room1.TV == true && room2.TV == true)
				return true;
			return false;
		}

		// Перевантажуємо логічний оператор !
		public static bool operator !(Room room)
		{
			if (room.balcony == true)
				return true;
			return false;
		}

		// Перевантажуємо оператор true
		public static bool operator true(Room room)
		{
			if (room.TV == true)
				return true;
			return false;
		}

		// Перевантажуємо оператор false
		public static bool operator false(Room room)
		{
			if (room.TV == false)
				return true;
			return false;
		}

		/// <summary>
		/// Initialization Constructor
		/// </summary>
		/// <param name="roomID"></param>
		/// <param name="roomNumber"></param>
		/// <param name="roomName"></param>
		/// <param name="roomSize"></param>
		/// <param name="hotel"></param>
		/// <param name="tv"></param>
		/// <param name="roomType"></param>
		/// <param name="numberOfBeds"></param>
		/// <param name="balcony"></param>
		public Room(int roomID, int roomNumber, string roomName,
			int roomSize, Hotel hotel, bool? tv, string roomType,
			int numberOfBeds, bool? balcony)
		{
			RoomID = roomID;
			RoomNumber = roomNumber;
			RoomName = roomName;
			RoomSize = roomSize;
			Hotel = hotel;
			TV = tv;
			RoomType = roomType;
			NumberOfBeds = numberOfBeds;
			Balcony = balcony;

			Console.WriteLine($"Додано кiмнату номер {RoomNumber} готелю " +
				$"{Hotel.HotelName}");
		}

		/// <summary>
		/// Copy constructor
		/// </summary>
		/// <param name="room"></param>
		public Room(Room room)
		{
			RoomID = room.RoomID;
			RoomNumber = room.RoomNumber;
			RoomName = room.RoomName;
			RoomSize = room.RoomSize;
			Hotel = room.Hotel;
			TV = room.TV;
			RoomType = room.RoomType;
			NumberOfBeds = room.NumberOfBeds;
			Balcony = room.Balcony;

			Console.WriteLine("Додано копiю кiмнати");
		}

		/// <summary>
		/// Implements the operator ++.
		/// </summary>
		/// <param name="r">room.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static Room operator ++(Room r)
		{
			r.NumberOfBeds++;
			return r;
		}

		/// <summary>
		/// Implements the operator --.
		/// </summary>
		/// <param name="r">room.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static Room operator --(Room r)
		{
			r.NumberOfBeds--;
			return r;
		}

		/// <summary>
		/// Implements the operator ==.
		/// </summary>
		/// <param name="r1">The 1 room.</param>
		/// <param name="r2">The 2 room.</param>
		/// <returns>
		/// The result of the operator.
		/// </returns>
		public static bool operator ==(Room r1, Room r2)
		{
			// If parameter is null, return false.
			if (Object.ReferenceEquals(r1, null) ||
			   Object.ReferenceEquals(r2, null))
			{
				return false;
			}

			// Optimization for a common success case.
			if (Object.ReferenceEquals(r1, r2))
			{
				return true;
			}

			// If run-time types are not exactly the same, return false.
			if (r1.GetType() != r2.GetType())
			{
				return false;
			}

			// Return true if the fields match.
			return (r1.NumberOfBeds == r2.NumberOfBeds) && (r1.RoomSize == r2.RoomSize) &&
				(r1.TV == r2.TV) && (r1.Balcony == r2.Balcony);
		}
		public static bool operator !=(Room r1, Room r2)
		{
			// If parameter is null, return true.
			if (Object.ReferenceEquals(r1, null) ||
			   Object.ReferenceEquals(r2, null))
			{
				return true;
			}

			// Optimization for a common success case.
			if (Object.ReferenceEquals(r1, r2))
			{
				return false;
			}

			// If run-time types are not exactly the same, return true.
			if (r1.GetType() != r2.GetType())
			{
				return true;
			}

			// Return true if the fields match.
			return !((r1.NumberOfBeds == r2.NumberOfBeds) && (r1.RoomSize == r2.RoomSize) &&
				(r1.TV == r2.TV) && (r1.Balcony == r2.Balcony));
		}
	}
}
