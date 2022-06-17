using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;


namespace AirLineTicketReservationSystem
{
    class insert : Ticket
    {
        private string name;
        private int id;

        public insert(string name, int id, ShowTicket showTicket) : base(showTicket)
        {


            this.name = name;
            this.id = id;

        }

        public void showTicket()
        {


            ShowTicket.showinsert(name, id);
        }
    






    Connection con = new Connection();
        SqlCommand cmd = null;


        string fullname, gender, CNICNo, numberofpassengers, totalfare, _class, location, destination, flightNo;

        public insert(string fname, string g, string cnic, string nop, string tf, string _clss, string l, string d, string fno)
        {
            fullname = fname;
            gender = g;
            CNICNo = cnic;
            numberofpassengers = nop;
            totalfare = tf;
            _class = _clss;
            location = l;
            destination = d;
            flightNo = fno;


        }

        public string insertcustomer()
        {

            try
            {
                cmd = new SqlCommand("Insert Into customerDetails VALUES('" + fullname + "','" + gender + "','" + CNICNo + "','" + numberofpassengers + "','" + _class + "','" + location + "','" + destination + "','" + flightNo + "','" + totalfare + "') SELECT SCOPE_IDENTITY();", con.Connect());
                int ans = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();


                if (ans > 0)
                {
                    string ans1 = ans.ToString();
                    return ans1;
                }
                else
                {
                    return "Data Not Inserted";
                }
               


            }
            catch (Exception ex)
            {
                return ex.Message + "Data Not Inserted";
            }


        }
    }
    
}
