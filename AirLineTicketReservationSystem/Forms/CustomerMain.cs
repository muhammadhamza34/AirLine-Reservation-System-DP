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
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            m1.Show();
            this.Hide();
            m1.backinstant();
            m1.showbuttons();
            
            
        }

        private void flightschedulebtn_Click(object sender, EventArgs e)
        {
            FlightSchedule fs = new FlightSchedule();
            fs.Show();
            this.Hide();
        }

        private void flightroutebtn_Click(object sender, EventArgs e)
        {
            FlightRoute fr = new FlightRoute();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNICAndTicketNo c = new CNICAndTicketNo();
            c.Show();
            this.Close();
        }
        
    }
}
