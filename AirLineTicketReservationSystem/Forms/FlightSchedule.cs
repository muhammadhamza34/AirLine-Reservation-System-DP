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
    public partial class FlightSchedule : Form
    {
        





        






        
        
        public FlightSchedule()
        {
            InitializeComponent();
        }
        
        private void removeitemcb1(object i)
        {
            comboBox1.Items.Remove(i);
            
        }
        private void removeitemcb2(object i)
        {
            comboBox2.Items.Remove(i);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CustomerMain cm = new CustomerMain();
            cm.Show();
            this.Hide();
        }

        private void FlightSchedule_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Faisalabad");

            comboBox2.Items.Add("Karachi");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Faisalabad");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            comboBox2.Items.Add("Karachi");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Faisalabad");
        }

        private void checkschedulebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                this.Hide();
                FlightScheduleResult fsr = new FlightScheduleResult(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text.ToString());
            }
            else
            {
                MessageBox.Show("Please Select Location / Destination", "Error");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            comboBox1.Items.Clear();

            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Faisalabad");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;

            comboBox1.Items.Clear();
            comboBox1.Text = "";

            comboBox1.Items.Add("Karachi");
            comboBox1.Items.Add("Lahore");
            comboBox1.Items.Add("Faisalabad");


            

            comboBox2.Items.Clear();
            comboBox2.Text = "";


            comboBox2.Items.Add("Karachi");
            comboBox2.Items.Add("Lahore");
            comboBox2.Items.Add("Faisalabad");

            
            
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            removeitemcb2(comboBox1.SelectedItem);
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            removeitemcb1(comboBox2.SelectedItem);
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
