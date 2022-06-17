using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirLineTicketReservationSystem.Classes;
using static AirLineTicketReservationSystem.checkSeatAvailaibility;

namespace AirLineTicketReservationSystem
{
    static class Program
    {
        public class BridgePatternDemo
        {
           
  

        public class FactoryPatternDemo
        {
            public class CompositePatternDemo
            {



                public static void Main()


                {

                        Ticket economy = new insert("name", 1212, new economy());
                        Ticket business = new insert("name", 1212, new business());
                        economy.show();
                        business.show();





                        Search train1 = new Search("train", 1);
                    Search train2 = new Search("train", 2);
                    train1.add(train2);
                    Console.WriteLine(train1);

                    foreach(Search train in train1.getSubordinates())
                    {
                        Console.WriteLine(train1);

                    }
                

                    checkseatFactory cf = new checkseatFactory();
                    checkSeat seat1 = cf.Getseat("checkseatavailaibilty");
                    seat1.check();

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Main());
                }
            }
        }
    }
}
