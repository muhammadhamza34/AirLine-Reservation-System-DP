using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLineTicketReservationSystem
{
    public partial class TicketReport : Form
    {
        string fullname;
        int numberofPassengers;
        string _class;
        string FlightID;
        string gender;
        string CNICNo;
        private int fare;
        private int totalfare;

        public TicketReport()
        {
            InitializeComponent();
        }
        public TicketReport(string fid,string noofp,string _clss,string name,string g,string cnic,int _fare)
        {
            InitializeComponent();

            FlightID = fid;
            numberofPassengers = Convert.ToInt32(noofp);
            _class = _clss;
            fullname = name;
            gender = g;
            CNICNo = cnic;
            fare = _fare;
        

        }
        private void TicketReport_Load(object sender, EventArgs e)
        {
            namelbl.Text = fullname;
            genderlbl.Text = gender;
            cniclbl.Text = CNICNo;
            classlbl.Text = _class;
            noofplbl.Text = numberofPassengers.ToString();
            flightidlbl.Text = FlightID;
            farelbl.Text = fare.ToString() + " PKR";


            //for total fare (number of passengors x fare)

            totalfare = fare * numberofPassengers;
            totalfarelbl.Text = totalfare.ToString() + " PKR";


            if (FlightID == "MH121")
            {
                fromlbl.Text = "Karachi";
                tolbl.Text = "Lahore";

                departuretimelbl.Text = "9:15";
                arrivaltimelbl.Text = "10:30";

                datelbl.Text = "January 1st,2018";
            }
            else if (FlightID == "MH122")
            {
                fromlbl.Text = "Karachi";
                tolbl.Text = "Lahore";

                departuretimelbl.Text = "18:30";
                arrivaltimelbl.Text = "20:00";

                datelbl.Text = "January 1st,2018";
            }
            else if (FlightID == "MH21")
            {
                fromlbl.Text = "Lahore";
                tolbl.Text = "Faisalabad";

                departuretimelbl.Text = "12:30";
                arrivaltimelbl.Text = "1:00";

                datelbl.Text = "December 25th,2017";
            }

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            TicketReservation tr = new TicketReservation();
            tr.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert i = new insert(namelbl.Text, genderlbl.Text, cniclbl.Text, noofplbl.Text,totalfare.ToString(), classlbl.Text, fromlbl.Text, tolbl.Text, flightidlbl.Text);
            string ans = i.insertcustomer();
            

            if (ans != "Data Not Inserted")
            {
                DialogResult dr = MessageBox.Show("Your Ticket was successfuly reserved", "Ticket Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    ID id = new ID(ans);
                    id.Show();
                    this.Close();
                    
                }
            }
            else
            {

            }
        }
    }
}
