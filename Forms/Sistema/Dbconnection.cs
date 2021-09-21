using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema
{
    class Dbconnection
    {
        private static SqlConnection connection;

        private static SqlConnection Sqlconnection()
        {
            connection = new SqlConnection("Data Source = DS - 01; Initial Catalog = banco_leo; Persist Security Info = True; User ID = sa; Password = Cal$5123");
            connection.Open();
            return connection;
        }       

    }
}
