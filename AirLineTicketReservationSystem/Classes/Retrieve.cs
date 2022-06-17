using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;


namespace AirLineTicketReservationSystem
{
    class Retrieve
    {
        Connection con = new Connection();
        SqlCommand cmd = null;


        public string check(string ticketno, string cnic)
        {
            try
            {
                cmd = new SqlCommand("Select * From customerDetails Where customerID = '" + ticketno + "' AND customerCNIC = '" + cnic + "';", con.Connect());
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    con.Close();
                    return "Ticket Found";
                }
                else
                {
                    dr.Close();
                    con.Close();
                    return "Sorry! No ticket was registered on this Ticket / CNIC No.";
                }
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public DataTable getTicket(string id)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select * From customerDetails Where customerID = '" + id + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            
            catch(Exception ex)
            {
                String e = ex.Message;
            }
            
            return dt;
        }


        


    }
}
