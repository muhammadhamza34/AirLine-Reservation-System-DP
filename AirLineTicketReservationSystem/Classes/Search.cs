using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace AirLineTicketReservationSystem
{ //compositepattern
    public class Search
    {
        private String name;
        private int ticket;
        private List<Search> subordinates;

        public Search(String name,int ticket)
        {
            this.name = name;
            this.ticket = ticket;
            subordinates = new List<Search>();


        }
        public void Add(Search s)
        {
            subordinates.Add(s);

        }
        public void Remove(Search s)
        {
            subordinates.Remove(s);

        }
        public List<Search> getSubordinates()
        {
            return subordinates;

        }
        public String toString()
        {
            return ("Search : [Name: " + name + "ticket:" + ticket + "]");

        }
        

            Connection con = new Connection();
        SqlCommand cmd = null;
        public string Exception;
        public DataTable SearchAll()
        {
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;
        }
        public DataTable searchById(int id)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE customerID = '" + id + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;
        }

        
        public DataTable searchByClass(string _class)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE class = '" + _class + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;


        }
        public DataTable searchByFlightID(string fid)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE customerFlightNo = '" + fid + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;

        }
        public DataTable searchByIDAndClass(int _id, string _class)
        {

            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE customerID = '" + _id + "' AND class = '"+_class+"';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;
        }
        public DataTable searchByIDAndFlightID(int _id, string _fid)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE customerID = '" + _id + "' AND customerFlightNo = '" + _fid + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;

        }
        public DataTable searchByFlightIDAndClass(string _fid, string _class)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE class = '" +_class + "' AND customerFlightNo = '" + _fid + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;
        }
        public DataTable searchByIDAndFlightIDAndClass(int _id, string _fid, string _class)
        {
            DataTable dt = new DataTable();

            try
            {
                cmd = new SqlCommand("Select * FROM customerDetails WHERE customerID = '"+_id+"' AND class = '" + _class + "' AND customerFlightNo = '" + _fid + "';", con.Connect());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
            }
            con.Close();
            return dt;
        }


    }
}
