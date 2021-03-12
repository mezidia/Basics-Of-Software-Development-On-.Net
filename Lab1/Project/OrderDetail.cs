using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class OrderDetail
	{
		public int OrderDetailID { get; set; }
		public Order Order { get; set; }
		public Room Room { get; set; }
		public DateTime DateStart { get; set; }
		public DateTime DateEnd { get; set; }
		public decimal Price { get; set; }
		public string Comment { get; set; }

		public OrderDetail(int OrderDetailID, int OrderID, DateTime DateStart,
		                    DateTime DateEnd, decimal Price, string Comment)
		{
			this.OrderDetailID = OrderDetailID;
			this.DateStart = DateStart;
			this.DateEnd = DateEnd;
			this.Price = Price;
			this.Comment = Comment;
		}
	}
}
