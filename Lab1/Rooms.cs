using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Rooms
    {
        public int HotelId { get; set; }
        public int PriceInt { get; set; }
        public int RoomNumberInt { get; set; }
        public int FreeDatesInt { get; set; }
        public bool TVBool { get; set; }
        public string RoomTypeStr { get; set; }
        public int NumberOfBedsInt { get; set; }
        public bool BalconyBool { get; set; }
        public bool SaleBool { get; set; }

        public Rooms(int id, int price, int roomNum, int freeDates,
            bool tvBool, string roomType, int bedsNum, bool balconyBool,
            bool saleBool)
        {
            HotelId = id;
            PriceInt = price;
            RoomNumberInt = roomNum;
            FreeDatesInt = freeDates;
            TVBool = tvBool;
            RoomTypeStr = roomType;
            NumberOfBedsInt = bedsNum;
            BalconyBool = balconyBool;
            SaleBool = saleBool;
        }
    }
}
