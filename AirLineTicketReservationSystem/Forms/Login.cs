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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ActiveControl = unametbox;
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Main n1 = new Main();
            n1.Show();
            n1.backinstant();
            n1.showbuttons();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (unametbox.Text.ToString() == "admin" && pwtbox.Text.ToString() == "admin")
            {
                CustomerDetails cd = new CustomerDetails();
                cd.Show();
                this.Hide();
                MessageBox.Show("You are Logged in","Successfull");

                
                


            }
            else if (unametbox.Text.ToString() != "admin" && pwtbox.Text.ToString() == "admin")
            {
                MessageBox.Show("Wrong User ID","Error");
            }
            else if (unametbox.Text.ToString() == "admin" && pwtbox.Text.ToString() != "admin")
            {
                MessageBox.Show("Wrong Password", "Error");
            }
            else if (unametbox.Text.ToString() == "" && pwtbox.Text.ToString() == "")
            {
                MessageBox.Show("Please Enter User ID/Password", "Error");
            }
            else
            {
                MessageBox.Show("Wrong User ID/Password", "Error");
            }

        
        }
    }
}
