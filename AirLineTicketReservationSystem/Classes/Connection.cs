using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;


namespace AirLineTicketReservationSystem
{
    class Connection
    {
        private static SqlConnection obj_connection;
        //singleton
        public Connection() { }
        public static SqlConnection GetConnection()
        {
            if (obj_connection == null)
            {
                string connectionString  = @"Data Source=Muneeb1-PC\SQLEXPRESS;Initial Catalog=AirlineTicketReservationSystem;Integrated Security=True";
                Connection obj = new Connection();
                obj_connection = new SqlConnection(connectionString);

            }
            else
            {

            }
            return obj_connection;


        }
    
        
    }
}
