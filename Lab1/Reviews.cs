using System;

namespace Hotel
{
	class Reviews
	{
		DateTime CreationDate { get; set; }
		int HotelId { get; set; }
		int RatingInt { get; set; }
		int ReviewId { get; set; }
		string ReviewStr { get; set; }
		int UserId { get; set; }

		public Reviews(DateTime date, int hotelID,
			int rating, int reviewID, string reviewStr,
			int user)
		{
			CreationDate = date;
			HotelId = hotelID;
			RatingInt = rating;
			ReviewId = reviewID;
			ReviewStr = reviewStr;
			UserId = user;
		}
	}
}
