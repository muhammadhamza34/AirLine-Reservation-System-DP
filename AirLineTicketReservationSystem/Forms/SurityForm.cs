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
    public partial class SurityForm : Form
    {
        Delete d = new Delete();
        static int customerID;


        public SurityForm()
        {
            InitializeComponent();
        }
        public SurityForm(string customername,int _id)
        {
            SurityForm sf = new SurityForm();
            customerID = _id;
            
            sf.label1.Text = "Are you Sure you want to delete '" + customername + "' from your record";
            sf.Show();

            
        }

        private void SurityForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = d.deleteByID(customerID);
            
            this.Hide();
            MessageBox.Show(ans);

            DeleteForm df = new DeleteForm();
            df.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteForm df = new DeleteForm();
            df.Show();
        }
    }
}
