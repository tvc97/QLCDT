using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QL_CDT.DAL
{
    public static class ConnectionDB
    {       
        public static SqlConnection getConnection()
        {
            string StringConnection = "Data Source=DESKTOP-DJ9KR3A;Initial Catalog=CuocDT;Integrated Security=True";
            SqlConnection conn = new SqlConnection(StringConnection);
            return conn;
        }
        public static bool CheckConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Open)
                return true;
            return false;
        }
    }
}