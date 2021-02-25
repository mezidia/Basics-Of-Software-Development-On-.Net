namespace Hotel
{
	class HotelAdmin : Authorized
	{
		protected int HotelId;

		public bool UpdateHotelInfo()
		{
			return true;
		}

		public void CheckHotelBooking()
		{

		}

		public bool UpdateRoom()
		{
			return true;
		}
	}
}
