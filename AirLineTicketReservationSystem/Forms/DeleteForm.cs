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
    public partial class DeleteForm : Form
    {
        Search s = new Search();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = s.SearchAll();

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.Text = "Select Customer";

            ActiveControl = this;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Select Customer" && comboBox1.Text != "")
            {
                SurityForm sf = new SurityForm(comboBox1.Text,Convert.ToInt32(comboBox1.SelectedValue));

                this.Close();

            }
            else
            {
                MessageBox.Show("Please Select any Customer First");
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            cd.Show();
            this.Hide();
        }

        private void selectcustomercb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
