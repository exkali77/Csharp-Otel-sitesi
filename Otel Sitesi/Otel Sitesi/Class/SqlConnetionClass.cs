using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Otel_Sitesi.Class
{
    public class SqlConnetionClass
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-EASQMRG\\SQLEXPRESS;Initial Catalog=Otel_Sitesi;Integrated Security=True");
       
        public static void CheckConnetion()
        {
            if (connection.State==System.Data.ConnectionState.Closed)
            {
                connection.Open();

            }
            else
            {

            }


        }
    }
}