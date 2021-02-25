using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	class DBSystem
	{
		public Reviews GetReviews(int reviewId)
		{
			return new Reviews();
		}

		public Hotels GetRoom(int id)
		{
			return new Hotels();
		}

		public User GetUser(int id)
		{
			return new User();
		}

		public Hotels GetHotel(int id)
		{
			return new Hotels();
		}
	}
}
