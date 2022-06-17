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
    public partial class FlightRoute : Form
    {
        int bigcloud = 800;
        int smallcloud = 800;
        int mediumcloud = 270;
        int planeheight = 475;
        int count1, count2 = 0;
        bool flag = false;
        
        public FlightRoute()
        {
            InitializeComponent();
        }

        private void FlightRoute_Load(object sender, EventArgs e)
        {
            bigcloudpb.Location = new System.Drawing.Point(840, 559);
            smallcloudpb.Location = new System.Drawing.Point(840, 369);
            mediumcloudpb.Location = new System.Drawing.Point(180, 365);
            timer1.Start();
            timer2.Start();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            CustomerMain cm = new CustomerMain();
            cm.Show();
            this.Close();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bigcloud -= 2;
            bigcloudpb.Location = new System.Drawing.Point(bigcloud, 559);

            mediumcloud -= 2;
            mediumcloudpb.Location = new System.Drawing.Point(mediumcloud, 365);

            if (flag == false)
            {
                if (bigcloud < 630)
                {
                    smallcloud -= 2;
                    smallcloudpb.Location = new System.Drawing.Point(smallcloud, 369);
                    flag = true;
                }
            }
            else
            {
                smallcloud -= 2;
                smallcloudpb.Location = new System.Drawing.Point(smallcloud, 369);
            }

            if (bigcloud == -190 || bigcloud == -191)
            {
                bigcloud = 840;
            }
            if (smallcloud == -190 || smallcloud == -191)
            {
                smallcloud = 840;
            }
            if (mediumcloud == -190 || mediumcloud == 191)
            {
                mediumcloud = 840;
            }

            

        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            if (count1 < 10)
            {
                count1++;
                planeheight--;
                planepb.Location = new System.Drawing.Point(291, planeheight);
            }


                if (count1 == 10)
                {

                    count2++;
                    planeheight++;
                    planepb.Location = new System.Drawing.Point(291, planeheight);

                    if (count2 == 10)
                    {
                        count1 = 0;
                        count2 = 0;

                    }
                }
            

            
            


        
            

            


        }
    }
}
