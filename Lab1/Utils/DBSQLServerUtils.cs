using System.Data.SqlClient;

namespace Hotel
{
	class DBSQLServerUtils
	{
		public static SqlConnection GetDBConnection
			(string datasource, string database,
			string username, string password)
		{
			return new SqlConnection();
		}
	}
}
