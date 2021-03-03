using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Hotel
    {
        int NumberOfStars;
        string Description;
        int RatingInt;
        public int HotelID { get; set; }
        public string HotelName { get; set; }
        public City City { get; set; }
        public string Adress { get; set; }

        public Hotel(int HotelID, string HotelName, string Adress)
        {

        }
    }
}
