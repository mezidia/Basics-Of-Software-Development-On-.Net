using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Room
    {
        public Hotel Hotel;
        public int RoomNumber;
        public bool TV;
        public string RoomType;
        public int NumberOfBeds;
        public bool Balcony;

        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomSize { get; set; }
        public int HotelID { get; set; }
        public decimal Price { get; set; }

        public Room(int RoomID, string RoomName,
            int RoomSize, int HotelID, decimal Price)
        {
            this.RoomID = RoomID;
            this.RoomName = RoomName;
            this.RoomSize = RoomSize;
            this.HotelID = HotelID;
            this.Price = Price;

            Console.WriteLine("Room is Created");
        }
    }
}
