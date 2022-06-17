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
    public partial class SeatAvailability : Form
    {
        private static string flightNO;
        public SeatAvailability()
        {
            InitializeComponent();
        }
        public void setFlightNo(string fno)
        {
            flightNO = fno;
        }
       
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
          

            string[] arr = new string[3];
            if (passengercombobox.Text != "")
            {
                checkSeatAvailaibility csa = new checkSeatAvailaibility();
                arr = csa.checkseats(passengercombobox.Text.ToString());
                

                if (arr[0] == "Available")
                {
                    economylbl.ForeColor = Color.DarkGreen;
                    economylbl.Text = arr[0];
                }
                else
                {
                    economylbl.ForeColor = Color.Red;
                    economylbl.Text = arr[0];
                }

                if (arr[1] == "Available")
                {
                    businesslbl.ForeColor = Color.DarkGreen;
                    businesslbl.Text = arr[1];
                }
                else
                {
                    businesslbl.ForeColor = Color.Red;
                    businesslbl.Text = arr[1];
                }

                if (arr[2] == "Available")
                {
                    firstclasslbl.ForeColor = Color.DarkGreen;
                    firstclasslbl.Text = arr[2];
                }
                else
                {
                    firstclasslbl.ForeColor = Color.Red;
                    firstclasslbl.Text = arr[2];
                }




                if (firstclasslbl.Text == "Available" && economylbl.Text == "Available" && businesslbl.Text == "Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Economy Class");
                    classcombobox.Items.Add("Business Class");
                    classcombobox.Items.Add("First Class");
                }
                else if (firstclasslbl.Text == "Not Available" && economylbl.Text == "Available" && businesslbl.Text == "Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Economy Class");
                    classcombobox.Items.Add("Business Class");
                }
                else if (firstclasslbl.Text == "Available" && economylbl.Text == "Not Available" && businesslbl.Text == "Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Business Class");
                    classcombobox.Items.Add("First Class");
                }
                else if (firstclasslbl.Text == "Available" && economylbl.Text == "Available" && businesslbl.Text == "Not Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Economy Class");
                    classcombobox.Items.Add("First Class");
                }
                else if (firstclasslbl.Text == "Not Available" && economylbl.Text == "Not Available" && businesslbl.Text == "Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Business Class");
                }
                else if (firstclasslbl.Text == "Available" && economylbl.Text == "Not Available" && businesslbl.Text == "Not Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("First Class");
                }
                else if (firstclasslbl.Text == "Not Available" && economylbl.Text == "Available" && businesslbl.Text == "Not Available")
                {
                    classcombobox.Items.Clear();

                    classcombobox.Items.Add("Economy Class");
                }
                else
                {
                    classcombobox.Items.Clear();

                   
                }



                }
            
            else
            {
                MessageBox.Show("Please Select Number of Passengers");
            }


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (flightNO == "MH121" || flightNO == "MH122")
            {
                FlightScheduleResult fsr = new FlightScheduleResult();
                fsr.twoflights();
            }
            else
            {
                FlightScheduleResult fsr = new FlightScheduleResult();
                fsr.oneflight();
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
           
            if (economylbl.Text == "" && firstclasslbl.Text == "" && businesslbl.Text == "")
            {
                MessageBox.Show("Please Check Seat Availability First", "Error");
               
            }
            else if (economylbl.Text == "Not Available" && firstclasslbl.Text == "Not Available" && businesslbl.Text == "Not Available")
            {
                MessageBox.Show("All Classes are already booked");
                
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (classcombobox.Text != "")
            {
                TicketReservation tr = new TicketReservation(flightNO,passengercombobox.Text,classcombobox.Text);
                tr.Show();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Please Select Class First","Error");
            }
        }

        private void SeatAvailability_Load(object sender, EventArgs e)
        {

        }

        private void passengercombobox_TextChanged(object sender, EventArgs e)
        {
            classcombobox.Items.Clear();

            
            string a = passengercombobox.Text;
            if (a.All(Char.IsDigit))
            {

            }
            else if (a == "-")
            {
                MessageBox.Show("Numbers of Passengers must be Positive Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passengercombobox.Text = "";

            }
            else
            {
                MessageBox.Show("Numbers of Passengers must be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                passengercombobox.Text = "";
            }

        }

        private void passengercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
