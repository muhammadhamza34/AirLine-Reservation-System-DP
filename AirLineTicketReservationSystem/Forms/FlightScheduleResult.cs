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
    public partial class FlightScheduleResult : Form
    {
        private string date;
        

        public FlightScheduleResult()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            bookbtn.Visible = false;
            
            
        }
        public FlightScheduleResult(string from, string to, string _date)
        {
            date = _date;
            
            if (from == "Karachi" && to == "Lahore" && _date == "01-01-2018")
            {
                twoflights();
            }
            else if (from == "Lahore" && to == "Faisalabad" && _date == "25-12-2017")
            {
                oneflight();
            }
            else
            {
                FlightScheduleResult f = new FlightScheduleResult();
                f.Show();
                f.availabilitylbl.Text = "No Desired Flights are Available on "+date+"";
            }
        }

        public void twoflights()
        {
            

            FlightScheduleResult f = new FlightScheduleResult();
            
            f.Show();
            f.groupBox1.Visible = true;
            f.groupBox2.Visible = true;
            f.bookbtn.Visible = true;

            
            f.fidlbl.Text = "MH121";
            f.fidlbl1.Text = "MH122";

            f.fromlbl.Text = "Karachi";
            f.fromlbl1.Text = "Karachi";

            f.tolbl.Text = "Lahore";
            f.tolbl1.Text = "Lahore";

            f.departlbl.Text = "9:15";
            f.arrivallbl.Text = "10:30";

            f.departurelbl1.Text = "18:30";
            f.arrivallbl1.Text = "20:00";

            f.farelbl.Text = "Economy : 7,000 PKR\nBusiness : 9,000 PKR \nFirst Class : 12,000 PKR";
            f.farelbl1.Text = "Economy : 7,000 PKR\nBusiness : 9,000 PKR \nFirst Class : 12,000 PKR";

            f.availabilitylbl.Text = "Total 2 Flights are Available on "+date+"";
            
        }
        public void oneflight()
        {
            FlightScheduleResult f = new FlightScheduleResult();

            f.Show();
            f.groupBox1.Visible = true;
            f.bookbtn.Visible = true;

            f.fidlbl.Text = "MH21";
            f.fromlbl.Text = "Lahore";
            f.tolbl.Text = "Faisalabad";
            f.departlbl.Text = "12:30";
            f.arrivallbl.Text = "1:00";
            f.farelbl.Text = "Economy : 2500 PKR\nBusines : 3500 PKR\nFirst Class : 4400 PKR";

            f.availabilitylbl.Text = "Total 1 Flight is Avaialable on "+date+"";
        }
        

        private void FlightScheduleResult_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           

        }
        

        private void bookbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.Hide();
                checkSeatAvailaibility n1 = new checkSeatAvailaibility(fidlbl.Text.ToString());
                
            }
            else if (checkBox2.Checked == true)
            {
                this.Hide();
                checkSeatAvailaibility n1 = new checkSeatAvailaibility(fidlbl1.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please Select any Flight First");
            }
        }

        private void fromlbl_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tolbl_Click(object sender, EventArgs e)
        {

        }

        private void fidlbl_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox2.Checked = false;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
               
                checkBox1.Checked = false;
            }
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            FlightSchedule fs = new FlightSchedule();
            this.Hide();
            fs.Show();
        }
    }
}
