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

        public Order(int OrderID, string OrderNumber)
        {

        }

    }
}
