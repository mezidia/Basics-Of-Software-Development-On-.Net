namespace Hotel
{
	class Hotels
	{
		int CountryId { get; set; }
		int OwnerId { get; set; }
		int NumberOfStarsInt { get; set; }
		string DescriptionStr { get; set; }
		int LocationInt { get; set; }
		int HotelTypeInt { get; set; }
		int RatingInt { get; set; }
		string HotelNameStr { get; set; }

		public Hotels(int countryID, int ownerID, int NumOfStars,
			string description, int location, int hotelType,
			int rating, string hotelName)
		{
			CountryId = countryID;
			OwnerId = ownerID;
			NumberOfStarsInt = NumOfStars;
			DescriptionStr = description;
			LocationInt = location;
			HotelTypeInt = hotelType;
			RatingInt = rating;
			HotelNameStr = hotelName;
		}
	}
}
