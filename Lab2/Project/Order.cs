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

		private Hotel hotel;

		/// <summary>
		/// We need this to get and set Hotel.
		/// Also We check if value isn't null
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
					Console.WriteLine("Введіть непорожній готель");
				}
			}
		}

		private User user;

		/// <summary>
		/// We need this to get and set User.
		/// Also We check if value isn't null
		/// </summary>
		public User User
		{
			get
			{
				return user;
			}

			set
			{
				if (value != null)
				{
					user = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожнього користувача");
				}
			}
		}

		private string orderNumber;

		/// <summary>
		/// We need this to get and set OrderNumber.
		/// Also We check if value isn't null
		/// </summary>
		public string OrderNumber
		{
			get
			{
				return orderNumber;
			}

			set
			{
				if (value != null)
				{
					orderNumber = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожній номер замовлення");
				}
			}
		}

		private Room room;

		/// <summary>
		/// We need this to get and set Order.
		/// Also We check if value isn't null
		/// </summary>
		public Room Room
		{
			get
			{
				return room;
			}

			set
			{
				if (value != null)
				{
					room = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожню кімнату");
				}
			}
		}

		private DateTime dateStart;

		/// <summary>
		/// We need this to get and set Order.
		/// Also We check if value isn't null
		/// </summary>
		public DateTime DateStart
		{
			get
			{
				return dateStart;
			}

			set
			{
				if (value != null)
				{
					dateStart = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожню дату початку");
				}
			}
		}

		private DateTime dateEnd;

		/// <summary>
		/// We need this to get and set Order.
		/// Also We check if value isn't null
		/// </summary>
		public DateTime DateEnd
		{
			get
			{
				return dateEnd;
			}

			set
			{
				if (value != null)
				{
					dateEnd = value;
				}
				else
				{
					Console.WriteLine("Введіть непорожню дату закінчення");
				}
			}
		}

		public Order(int orderID, decimal sum,
			Hotel hotel, User user, string orderNumber,
			Room room, DateTime start, DateTime end)
		{
			OrderID = orderID;
			Sum = sum;
			Hotel = hotel;
			User = user;
			OrderNumber = orderNumber;
			Room = room;
			DateStart = start;
			DateEnd = end;

			Console.WriteLine("Order is created");
		}
	}
}
