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
    public partial class CNICAndTicketNo : Form
    {
        public CNICAndTicketNo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acc = ticketnotb.Text;
            string cn = cnicnotb.Text;

            if ((ticketnotb.Text != "" && acc.All(char.IsDigit)) && (cnicnotb.Text != "" && cnicnotb.TextLength == 13 && cn.All(char.IsDigit)))
            {
                Retrieve r = new Retrieve();
                string ans = r.check(ticketnotb.Text, cnicnotb.Text);
                if (ans == "Ticket Found")
                {
                    PrintTicket pt = new PrintTicket(ticketnotb.Text);
                    pt.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(ans,"Ticket Not Found",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsLetter)) && (cnicnotb.Text != "" && cnicnotb.TextLength == 13 && cn.All(char.IsDigit)))
            {
                MessageBox.Show("Ticket number should be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsDigit)) && (cnicnotb.Text != "" && cnicnotb.TextLength == 13 && cn.All(char.IsLetter)))
            {
                MessageBox.Show("CNIC number should be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsDigit)) && (cnicnotb.Text != "" && cnicnotb.TextLength != 13 && cn.All(char.IsLetter)))
            {
                MessageBox.Show("CNIC number should be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsDigit)) && (cnicnotb.Text != "" && cnicnotb.TextLength != 13 && cn.All(char.IsDigit)))
            {
                MessageBox.Show("CNIC number should be of 13 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsLetter)) && (cnicnotb.Text != "" && (cnicnotb.TextLength != 13 || cnicnotb.TextLength == 13) && cn.All(char.IsLetter)))
            {
                MessageBox.Show("Both Ticket and CNIC Number should be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((ticketnotb.Text != "" && acc.All(char.IsLetterOrDigit)) && (cnicnotb.Text != "" && (cnicnotb.TextLength != 13 || cnicnotb.TextLength == 13) && cn.All(char.IsLetterOrDigit)))
            {
                MessageBox.Show("Both Ticket and CNIC Number should be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else
            {
                MessageBox.Show("Please fill the required details properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CustomerMain cm = new CustomerMain();
            cm.Show();
            this.Close();
        }
    }
}
