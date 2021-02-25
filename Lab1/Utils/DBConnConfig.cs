using System.Data.SqlClient;

namespace Hotel
{
	class DBConnConfig
	{
		public static SqlConnection GetDBConnection()
		{
			return new SqlConnection();
		}
	}
}
