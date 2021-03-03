using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	class DBSystem
	{
		public DBSystem()
		{
			User Admin = new User(1, 1, "FirstUser",
			"RandomEmail@gmail.com", "88005553535");
			Role AdminRole = new Role(1, "Admin");
			Admin.Roles.Add(AdminRole);
			Hotel FirstHotel = new Hotel(1, "First", "KPI Street");
			Admin.AddHotel();
			Console.WriteLine("DBSystem has started");
		}
	}
}
