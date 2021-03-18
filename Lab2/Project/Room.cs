using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Room
    {
        public Hotel hotel;
        public int roomNumber;
        public bool tv;
        public string roomType;
        public int numberOfBeds;
        public bool balcony;
        public int roomID;
        public string roomName;
        public int roomSize;
        public int hotelID;
        public decimal price;

        public Room(int RoomID, string RoomName,
            int RoomSize, int HotelID, decimal Price)
        {
            roomID = RoomID;
            roomName = RoomName;
            roomSize = RoomSize;
            hotelID = HotelID;
            price = Price;

            Console.WriteLine("Room is Created");
        }
    }
}
