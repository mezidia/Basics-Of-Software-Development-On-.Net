using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Hotel
	{
		private int numberofstars;
        private string description;
		private int ratingint;
		private int hotelid;
		private string hotelname;
		private string adress;

		public int NumberOfStars
        {
			get
			{
				return numberofstars;
			}
			set
			{
				if (value.ToString() != null && value >= 1 && value <= 5) numberofstars = value;
				else Console.WriteLine("Введіть правильну кількість зірок.");
			}
        }
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
		public int RatingInt
        {
			get
			{
				return ratingint;
			}
			set
            {
				if (value.ToString() != null) ratingint = value;
				else Console.WriteLine("Введіть не пустий ідентифікатор рейтингу");
            }
        }
		public int HotelID
		{
			get
			{
				return hotelid;
			}
			set
			{
				if (value.ToString() != null) hotelid = value;
				else Console.WriteLine("Введіть не пустий ідентифікатор готелю.");
			}
		}
		public string HotelName 
		{ 
			get
            {
				return hotelname;
            }
			set
            {
				if (value.Length() < 15) hotelname = value;
				else Console.WriteLine("Забагато символів для імені готелю.");
            }
		}
		public City City { get; set; }
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
