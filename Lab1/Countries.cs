namespace Hotel
{
	class Countries
	{
		int CountryId { get; set; }
		string CountryName { get; set; }

		public Countries(int country, string name)
		{
			CountryId = country;
			CountryName = name;
		}
	}
}
