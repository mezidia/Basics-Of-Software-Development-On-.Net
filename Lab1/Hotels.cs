namespace Hotel
{
	class Hotels
	{
		int CountryId;
		int OwnerId;
		int NumberOfStarsInt;
		string DescriptionStr;
		int LocationInt;
		int HotelTypeInt;
		int RatingInt;
		string HotelNameStr;

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
