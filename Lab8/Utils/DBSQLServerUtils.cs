// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

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
