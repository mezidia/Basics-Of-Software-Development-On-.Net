using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    public class Review
    {
        int ReviewId { get; set; }
        DateTime CreationDate { get; set; }
        Hotel Hotel { get; set; }
        int Rating { get; set; }
        string Description { get; set; }
        User User { get; set; }
        public Review(int RatingInt, int Rating, string Description)
        {

        }
    }
}
