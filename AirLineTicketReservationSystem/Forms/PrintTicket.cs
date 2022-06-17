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
    public partial class PrintTicket : Form
    {
        string ticketNo;
        public PrintTicket(string tn)
        {
            InitializeComponent();
            ticketNo = tn;
        }

        private void PrintTicket_Load(object sender, EventArgs e)
        {
            cancelbtn.Enabled = false;
            submitbtn.Enabled = false;
            fullnametb.Hide();
            cnictb.Hide();
            

            Retrieve r = new Retrieve();
            DataTable dt = r.getTicket(ticketNo);

            ticketnolbl.Text = dt.Rows[0][0].ToString();
            namelbl.Text = dt.Rows[0][1].ToString();
            genderlbl.Text = dt.Rows[0][2].ToString();
            cniclbl.Text = dt.Rows[0][3].ToString();
            noofplbl.Text = dt.Rows[0][4].ToString();
            classlbl.Text = dt.Rows[0][5].ToString();
            fromlbl.Text = dt.Rows[0][6].ToString();
            tolbl.Text = dt.Rows[0][7].ToString();
            flightidlbl.Text = dt.Rows[0][8].ToString();
            totalfarelbl.Text = dt.Rows[0][9].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CNICAndTicketNo c = new CNICAndTicketNo();
            c.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Ticket has been printed Successfully", "Print Report", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            namelbl.Hide();
            cniclbl.Hide();

            fullnametb.Show();
            cnictb.Show();

            fullnametb.Text = namelbl.Text;
            cnictb.Text = cniclbl.Text;

            printbtn.Enabled = false;
            updatebtn.Enabled = false;
            submitbtn.Enabled = true;
            cancelbtn.Enabled = true;
            
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            namelbl.Show();
            cniclbl.Show();

            fullnametb.Hide();
            cnictb.Hide();

            submitbtn.Enabled = false;
            updatebtn.Enabled = true;

            printbtn.Enabled = true;
            
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string a = cnictb.Text;

            if(fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength == 13 && (a.All(Char.IsDigit))))
            {

                update u = new update(fullnametb.Text, cnictb.Text,ticketNo);
                string ans = u.updateinfo();
                MessageBox.Show(ans, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                PrintTicket pr = new PrintTicket(ticketNo);
                pr.Show();
            }
            else if (fullnametb.Text != "" && cnictb.Text != "" && (cnictb.TextLength == 13 || cnictb.TextLength != 13) && (a.Any(Char.IsLetter)))
            {
                MessageBox.Show("CNIC Number must be in digits only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else if (fullnametb.Text != "" && (cnictb.Text != "" && cnictb.TextLength != 13 && a.All(Char.IsDigit)))
            {
                MessageBox.Show("CNIC Number must be of 13 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Please Fill the Fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
