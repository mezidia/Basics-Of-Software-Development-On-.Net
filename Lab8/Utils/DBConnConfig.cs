// Licensed to the Mezidia Foundation under one or more agreements.
// The Mezidia Foundation licenses this file to you under the MIT license.

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
