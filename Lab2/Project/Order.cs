using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Order
    {
        public int OrderID { get; set; }
        public decimal Sum { get; set; }
        public Hotel Hotel { get; set; }
        public User User { get; set; }
        public string OrderNumber { get; set; }

        public Order(int OrderID, decimal Sum,
            Hotel Hotel, User User, string OrderNumber)
        {
            this.OrderID = OrderID;
            this.Sum = Sum;
            this.Hotel = Hotel;
            this.User = User;
            this.OrderNumber = OrderNumber;

            Console.WriteLine("Order is created");
        }
    }
}
