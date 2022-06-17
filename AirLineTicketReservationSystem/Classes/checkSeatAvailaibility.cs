using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AirLineTicketReservationSystem
{ //factory pattern
    public interface checkSeat
    {
        void check();

    }
    class checkSeatAvailaibility : checkSeat
    {
        public void check()
        {

            Console.WriteLine("check seat");
        }
    
        public class checkseatFactory
        {
            public checkSeat Getseat(String seattype)
            {
                if (seattype == "full")
                {
                    return checkSeatAvailaibility();
                }
                return null;

            }

            private checkSeat checkSeatAvailaibility()
            {
                throw new NotImplementedException();
            }
        }






        private int totalfirstclasseats = 15;
        private int totalBusinessclassseats = 30;
        private int totalEconomyClassSeats = 50;
        private static string flightID;
        public string Exception;

        SqlCommand cmd = null;
        Connection con = new Connection();
        public  checkSeatAvailaibility()
        {
        }

        public checkSeatAvailaibility(string fid)
        {
            flightID = fid;
            openform();
        }
        
        private void openform()
        {
            
            SeatAvailability bt = new SeatAvailability();
            bt.Show();
            bt.setFlightNo(flightID);
        }

        public string[] checkseats(string noofpassengers)
        {
            string[] arr = new string[3];
           
            int nop = Convert.ToInt32(noofpassengers);
            

            int economyclassseats, businessclassseats, firstclassseats;
            
            try
            {

                cmd = new SqlCommand("Select * From customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'Economy Class';", con.Connect());
                
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read())
                {
                    DataTable dt = new DataTable();

                   
                    cmd = new SqlCommand("SELECT SUM(numberOfPassengers) as TotalEconomyClassSeats from customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'Economy Class';", con());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    economyclassseats = Convert.ToInt32(dt.Rows[0]["TotalEconomyClassSeats"]);
                    economyclassseats = totalEconomyClassSeats - (economyclassseats + nop);
                    
                }
                else
                {
                    economyclassseats = totalEconomyClassSeats;
                    economyclassseats = economyclassseats - nop;
                    
                }
                dr.Close();
                

                cmd = new SqlCommand("Select * From customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'Business Class';", con.Connect());
                
                SqlDataReader dr1 = cmd.ExecuteReader();
                
                if (dr1.Read())
                {
                    DataTable dt = new DataTable();

                    
                    cmd = new SqlCommand("SELECT SUM(numberOfPassengers) as TotalBusinessClassSeats from customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'Business Class';", con.Connect());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    businessclassseats = Convert.ToInt32(dt.Rows[0]["TotalBusinessClassSeats"]);
                    businessclassseats = totalBusinessclassseats - (businessclassseats + nop);

                    
                }
                else
                {
                    businessclassseats = totalBusinessclassseats;
                    businessclassseats = businessclassseats - nop;
                    
                }
                dr1.Close();
                

                cmd = new SqlCommand("Select * From customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'First Class';",con.Connect());
                
                SqlDataReader dr2 = cmd.ExecuteReader();
                
                if(dr2.Read())
                {

                    DataTable dt = new DataTable();

                   
                    cmd = new SqlCommand("SELECT SUM(numberOfPassengers) as TotalFirstClassSeats FROM customerDetails WHERE customerFlightNo = '" + flightID + "' AND class = 'First Class';", con.Connect());
                    
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    firstclassseats = Convert.ToInt32(dt.Rows[0]["TotalFirstClassSeats"]);
                    firstclassseats = totalfirstclasseats - (firstclassseats + nop);
                    
                }
              
                else
                {
                    firstclassseats = totalfirstclasseats;
                    firstclassseats = firstclassseats - nop;
                    
                }
                dr2.Close();
                
                

                if (economyclassseats >= 0)
                {
                    arr[0] = "Available";

                }
                else
                {
                    arr[0] = "Not Available";
                }
                if (businessclassseats >= 0)
                {
                    arr[1] = "Available";
                }
                else
                {
                    arr[1] = "Not Available";
                }
                if (firstclassseats >= 0)
                {
                    arr[2] = "Available";
                }
                else
                {
                    arr[2] = "Not Available";
                }

            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            

            return arr;
           


        }

        public void check()
        {
            throw new NotImplementedException();
        }
    }
}



            
                
                
        



    

