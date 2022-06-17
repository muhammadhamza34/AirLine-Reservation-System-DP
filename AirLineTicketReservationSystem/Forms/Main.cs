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
   





    public partial class Main : Form
    {
        bool pictureboxflag = false;
        bool labelflag = false;
        

        int pictureboxpos = -150;
        int welcomelabelsize = 0;
        int waitingtime = 0;
        public Main()
        {
            InitializeComponent();
        }
        public void showbuttons()
        {
            enteraslbl.Show();
            administratorbtn.Show();
            Customerbtn.Show();
            exitbtn.Show();
            administratorbtn.Enabled = true;
            Customerbtn.Enabled = true;
        }
        public void backinstant()
        {
            pictureBox1.Hide();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            welcomelbl.Hide();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            exitbtn.Hide();
            enteraslbl.Hide();
            Customerbtn.Hide();
            administratorbtn.Hide();
            pictureBox1.Hide();
            timer1.Start();
            timer2.Start();
            administratorbtn.Enabled = false;
            Customerbtn.Enabled = false;

            
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (pictureboxflag == false)
            {

                pictureBox1.Show();

                pictureboxpos += 2;

                pictureBox1.Location = new Point(pictureboxpos, 25);
                if (pictureboxpos == 268)
                {
                    pictureboxpos = 267;
                    pictureBox1.Location = new Point(pictureboxpos, 25);
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Start();

                }
            }
            else if(pictureboxflag == true)
            {
                pictureboxpos += 3;
                pictureBox1.Location = new Point(pictureboxpos, 25);
                if (pictureboxpos == 702)
                {
                    timer1.Stop();
                    showbuttons();
                    
                    
                    
                }
            }
            


                
            
            
        }

        private void welcomelbl_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelflag == false)
            {
                welcomelabelsize++;
                float size = (float)(welcomelabelsize);
                welcomelbl.Font = new Font("Maiandra GD", size);
            }
            else if (labelflag == true)
            {
                welcomelabelsize -= 2;
                float size = (float)(welcomelabelsize);
                welcomelbl.Font = new Font("Maiandra GD", size);
                if (welcomelabelsize == 2 || welcomelabelsize == 3 || welcomelabelsize == 1)
                {
                    
                    timer2.Stop();
                    welcomelbl.Hide();
                }
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            waitingtime++;
            if (waitingtime == 1)
            {
                pictureboxflag = true;
                labelflag = true;
                timer3.Stop();
                timer1.Start();
                timer2.Start();
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Customerbtn_Click(object sender, EventArgs e)
        {
            CustomerMain cm = new CustomerMain();
            cm.Show();
            this.Hide();
        }

        private void administratorbtn_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
