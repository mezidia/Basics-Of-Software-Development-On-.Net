using System;

namespace Hotel
{
	class Booking
	{
		int Book { get; set; }
		int User { get; set; }
		int Room { get; set; }
		string Description { get; set; }
		DateTime StartDate { get; set; }
		DateTime EndDate { get; set; }

		public Booking(int book, int user,
			int room, string description,
			DateTime start, DateTime end)
		{
			Book = book;
			User = user;
			Room = room;
			Description = description;
			StartDate = start;
			EndDate = end;
		}
	}
}
