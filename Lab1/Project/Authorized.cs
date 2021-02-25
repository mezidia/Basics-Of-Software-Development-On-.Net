namespace Hotel
{
	class Authorized : User
	{
		protected string Email;
		protected string Login;
		protected string Password;
		protected int Age;
		protected int PhoneNumber;
		protected int Country;
		protected int Id;
		protected int Permission;

		public bool Book()
		{
			return true;
		}

		public Booking CheckBooking()
		{
			return new Booking();
		}

		public bool Review()
		{
			return true;
		}

		public bool CancelBooking()
		{
			return true;
		}

		public User LogOut()
		{
			return new Unauthorized();
		}

		public bool AddHotel()
		{
			return true;
		}
	}
}
