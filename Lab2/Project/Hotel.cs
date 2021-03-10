using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Hotel
	{
		int NumberOfStars;
		string Description;
		int RatingInt;
		public int HotelID { get; set; }
		public string HotelName { get; set; }
		public City City { get; set; }
		public string Adress { get; set; }
		List<Room> Rooms = new List<Room>();

		public Hotel(int HotelID, string HotelName, string Adress)
		{
			this.HotelID = HotelID;
			this.HotelName = HotelName;
			this.Adress = Adress;

			// Temp for Composition
			Room FirstRoom = new Room(1, "First", 1, HotelID);
			Rooms.Add(FirstRoom);
			Console.WriteLine("Hotel is Created");
		}

		public void CreateRoom(int ID, string name,
			int size, int hotelID)
		{
			Room room = new Room(ID, name, size, hotelID);
			Rooms.Add(room);
		}
	}
}
