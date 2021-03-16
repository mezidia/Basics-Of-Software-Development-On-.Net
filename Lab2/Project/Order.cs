using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Order
    {
        public int orderID { get; set; }
        public decimal sum { get; set; }
        public Hotel hotel { get; set; }
        public User user { get; set; }
        public string orderNumber { get; set; }
        public Room room { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }

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
