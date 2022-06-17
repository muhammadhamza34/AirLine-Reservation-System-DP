using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AirLineTicketReservationSystem
{
    class Delete
    {
       Connection con = new Connection();
       SqlCommand cmd = null;
     

       public string deleteByID(int customerID)
       {
           try
           {
               cmd = new SqlCommand("Delete FROM customerDetails WHERE customerID = '" + customerID + "';", con.Connect());
               cmd.ExecuteNonQuery();
               con.Close();

               return "Deleted Successfully";
           }
           catch (Exception ex)
           {
               return ex.Message + "Unable to Delete";
           }
       }

    }
}
