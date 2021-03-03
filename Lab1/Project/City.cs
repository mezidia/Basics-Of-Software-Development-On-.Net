using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
	public class City
	{
		public int CityID { get; set; }
		public string CityName { get; set; }
		public Country Country { get; set; }
		public City(int CityID, string CityName)
		{
			this.CityID = CityID;
			this.CityName = CityName;
		}
	}
}
