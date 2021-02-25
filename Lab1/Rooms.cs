using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    class Rooms
    {
        public int HotelId;
        public int PriceInt;
        public int RoomNumberInt;
        public int FreeDatesInt;
        public bool TVBool;
        public string RoomTypeStr;
        public int NumberOfBedsInt;
        public bool BalconyBool;
        public bool SaleBool;

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
