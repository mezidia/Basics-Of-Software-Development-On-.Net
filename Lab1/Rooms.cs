namespace Hotel
{
	class Rooms
	{
		int HotelId { get; set; }
		int PriceInt { get; set; }
		int RoomNumberInt { get; set; }
		int FreeDatesInt { get; set; }
		bool TVBool { get; set; }
		string RoomTypeStr { get; set; }
		int NumberOfBedsInt { get; set; }
		bool BalconyBool { get; set; }
		bool SaleBool { get; set; }

		public Rooms(int id, int price, int roomNum,
			int freeDates, bool tvBool, string roomType,
			int bedsNum, bool balconyBool, bool saleBool)
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
