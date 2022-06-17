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
    public partial class CustomerDetails : Form
    {
        Search s = new Search();
        public CustomerDetails()
        {
            InitializeComponent();
            
        }
        
        private void backbtn_Click(object sender, EventArgs e)
        {
            Login l2 = new Login();
            l2.Show();
            this.Hide();
            
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            
            DataTable dt = new DataTable();
            
            dt = s.SearchAll();
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = dt.Columns[0].ToString();
            comboBox1.DisplayMember = dt.Columns[1].ToString();
            comboBox1.Text = "All";

            
           
           
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == "All" || comboBox1.Text == "all" || comboBox1.Text == "ALL") && comboBox2.Text == "All" && comboBox3.Text == "All")
            {
                DataTable dt = new DataTable();
                
                
                dt = s.SearchAll();
                dataGridView1.DataSource = dt;

            }
            else if (comboBox1.Text != "All" && comboBox2.Text == "All" && comboBox3.Text == "All")
            {
                DataTable dt = new DataTable();

                dt = s.searchById(Convert.ToInt32(comboBox1.SelectedValue));
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "All" && comboBox2.Text != "All" && comboBox3.Text == "All")
            {
                DataTable dt = new DataTable();
                dt = s.searchByFlightID(comboBox2.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "All" && comboBox2.Text == "All" && comboBox3.Text != "All")
            {
                DataTable dt = new DataTable();
                dt = s.searchByClass(comboBox3.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text != "All" && comboBox2.Text != "All" && comboBox3.Text == "All")
            {
                DataTable dt = new DataTable();
                dt = s.searchByIDAndFlightID(Convert.ToInt32(comboBox1.SelectedValue), comboBox2.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text != "All" && comboBox2.Text == "All" && comboBox3.Text != "All")
            {
                DataTable dt = new DataTable();
                dt = s.searchByIDAndClass(Convert.ToInt32(comboBox1.SelectedValue), comboBox3.Text);
                dataGridView1.DataSource = dt;
            }
            else if (comboBox1.Text == "All" && comboBox2.Text != "All" && comboBox3.Text != "All")
            {
                DataTable dt = new DataTable();
                dt = s.searchByFlightIDAndClass(comboBox2.Text, comboBox3.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = s.searchByIDAndFlightIDAndClass(Convert.ToInt32(comboBox1.SelectedValue), comboBox2.Text, comboBox3.Text);
                dataGridView1.DataSource = dt;
            }
                
                

                
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "All";
            comboBox2.Text = "All";
            comboBox3.Text = "All";
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.Show();
            this.Hide();
            
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

       

       
    }
}
