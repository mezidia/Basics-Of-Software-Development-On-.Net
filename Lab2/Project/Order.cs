using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Order
    {
        public int orderID;
        public decimal sum;
        public Hotel hotel;
        public User user;
        public string orderNumber;
        public Room room;
        public DateTime dateStart;
        public DateTime dateEnd;

        public Order(int OrderID, decimal Sum,
            Hotel Hotel, User User, string OrderNumber,
            Room Room, DateTime Start, DateTime End)
        {
            orderID = OrderID;
            sum = Sum;
            hotel = Hotel;
            user = User;
            orderNumber = OrderNumber;
            room = Room;
            dateStart = Start;
            dateEnd = End;

            Console.WriteLine("Order is created");
        }
    }
}
