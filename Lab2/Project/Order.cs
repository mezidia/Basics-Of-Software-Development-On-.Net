using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class Order
	{
		private int orderID;

		/// <summary>
		/// We need this to get and set orderID.
		/// Also We check if value isn't null
		/// </summary>
		public int OrderID
		{
			get
			{
				return orderID;
			}

			set
			{
				if (value.ToString() != null && value < 0)
				{
					orderID = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожній ID");
				}
			}
		}

		private decimal sum;

		/// <summary>
		/// We need this to get and set Sum.
		/// Also We check if value isn't null
		/// </summary>
		public decimal Sum
		{
			get
			{
				return sum;
			}

			set
			{
				if (value.ToString() != null && value < 0)
				{
					sum = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожню суму");
				}
			}
		}

		private Hotel hotel { get; set; }
		private User user { get; set; }
		private string orderNumber { get; set; }
		private Room room { get; set; }
		private DateTime dateStart { get; set; }
		private DateTime dateEnd { get; set; }

		public Order(int OrderID, decimal Sum,
			Hotel Hotel, User User, string OrderNumber,
			Room Room, DateTime Start, DateTime End)
		{
			this.OrderID = OrderID;
			this.Sum = Sum;
			this.Hotel = Hotel;
			this.User = User;
			this.OrderNumber = OrderNumber;
			this.Room = Room;
			this.DateStart = Start;
			this.DateEnd = End;

			Console.WriteLine("Order is created");
		}
	}
}
