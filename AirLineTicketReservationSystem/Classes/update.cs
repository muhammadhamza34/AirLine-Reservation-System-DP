using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace AirLineTicketReservationSystem
{
    class update
    {
        string CNIC, fullname, customerid;
        Connection con = new Connection();
        SqlCommand cmd = null;

        public update(string name, string cnicno,string id)
        {

            fullname = name;
            CNIC = cnicno;
            customerid = id;

        }


        public string updateinfo()
        {
            try
            {
                cmd = new SqlCommand("UPDATE customerDetails SET customerFullName = '" + fullname + "',customerCNIC = '" + CNIC + "' WHERE customerID = '"+customerid+"';",con.Connect());
                cmd.ExecuteNonQuery();

                con.Close();
                return "Your Ticket Details were Successfully Updated";

            }
            catch (Exception ex)
            {

                return ex.Message + "Ticket details not updated"; 
            }



        }


    }
}
