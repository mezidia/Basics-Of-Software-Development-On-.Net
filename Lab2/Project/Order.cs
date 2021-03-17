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
        public Room Room { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }

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
