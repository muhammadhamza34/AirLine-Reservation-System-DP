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
    public partial class TicketReservation : Form
    {
        int count = 0;
        int count1 = 0;

        private static string flightNo;
        private static string noOfPassengers;
        private static string _class;
        private static int fare;
        public TicketReservation()
        {
            InitializeComponent();
        }
        public TicketReservation(string fno, string noofp,string _clss)
        {
            InitializeComponent();


            flightNo = fno;
            noOfPassengers = noofp;
            _class = _clss;

            if ((fno == "MH121" || fno == "MH122") && _class == "Economy Class")
            {
                fare = 7000;
            }
            else if ((fno == "MH121" || fno == "MH122") && _class == "Business Class")
            {
                fare = 9000;
            }
            else if ((fno == "MH121" || fno == "MH122") && _class == "First Class")
            {
                fare = 12000;
            }
            else if (fno == "MH21")
            {
                if (_class == "Economy Class")
                {
                    fare = 2500;
                }
                else if (_class == "Business Class")
                {
                    fare = 3500;
                }
                else if (_class == "First Class")
                {
                    fare = 4400;
                }
            }
        }



        private void TicketReservation_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            count++;

            notelbl.ForeColor = Color.Black;
            notelbl.BackColor = Color.Khaki;
            if (count > 7)
            {
                notelbl.BackColor = Color.Coral;
                notelbl.ForeColor = Color.MidnightBlue;
                count1++;
                if (count1 == 7)
                {
                    count = 0;
                    count1 = 0;
                }
            }
               
            
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (fullnametb.Text != "" || cnictb.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to go back ? All your entered details will be canceled", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    SeatAvailability sa = new SeatAvailability();
                    sa.Show();
                }
                else
                {
                }

            }
            else
            {
                this.Close();
                SeatAvailability sa = new SeatAvailability();
                sa.Show();

            }
            
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have to enter your 13-digit CNIC Number in this column","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void maleradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleradiobtn.Checked == true)
            {
                femaleradiobtn.Checked = false;
            }
        }

        private void femaleradiobtn_CheckedChanged(object sender, EventArgs e)
        {
            if (maleradiobtn.Checked == true)
            {
                maleradiobtn.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string natureoftext = cnictb.Text;
            if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength == 13 && natureoftext.All(Char.IsDigit)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                if (maleradiobtn.Checked == true)
                {
                    TicketReport tr = new TicketReport(flightNo, noOfPassengers, _class, fullnametb.Text, "Male", cnictb.Text,fare);
                    this.Close();
                    tr.Show();
                }
                else if (femaleradiobtn.Checked == true)
                {
                    TicketReport tr = new TicketReport(flightNo, noOfPassengers, _class, fullnametb.Text, "Female", cnictb.Text,fare);
                    this.Close();
                    tr.Show();
                }
            }
           
            
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength == 13 && natureoftext.All(Char.IsLetter)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Letters cannot be included in CNIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength != 13 && natureoftext.All(Char.IsLetter)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Letters cannot be included in CNIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength != 13 && natureoftext.All(Char.IsDigit)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("CNIC Number must be of 13-digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength != 13 && natureoftext.All(Char.IsLetterOrDigit)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Letters cannot be included in CNIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength == 13 && natureoftext.All(Char.IsLetterOrDigit)) && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Letters cannot be included in CNIC Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            

            else if (fullnametb.Text != "" && (cnictb.Text != "") && (maleradiobtn.Checked == false && femaleradiobtn.Checked == false))
            {
                MessageBox.Show("Please select your gender", "Error");
            }
            else if (fullnametb.Text != "" && (cnictb.Text == "") && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Please enter your CNIC Number", "Error");
            }
            else if (fullnametb.Text == "" && (cnictb.Text != "") && (maleradiobtn.Checked == true || femaleradiobtn.Checked == true))
            {
                MessageBox.Show("Please enter your Full name first", "Error");
            }
            else
            {
                MessageBox.Show("Please enter the required details first", "Error");
            }
            


            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cnictb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cnictb_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }
    }
}
