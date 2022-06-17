using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AirLineTicketReservationSystem.Classes
{
    //bridgepattern laga h insert aur ticker pr 
    public class Ticket
    {
        private ShowTicket showTicket;

       
        public interface ShowTicket
        {

            public void showdetails(string name);

            static void showinsert(string name, int id);
        }
        public class economy : ShowTicket
        {
            public void showdetails(string name)
            {

                Console.WriteLine("ticket name " + name);

            }

            public class business : ShowTicket
            {
                public void showdetails(string name)
                {

                    Console.WriteLine("ticket name " + name);

                }

            }

            public abstract class Ticket
            {

                protected ShowTicket showTicket;

                protected Ticket(ShowTicket showTicket)
                {

                    this.showTicket = showTicket;
                }
                public abstract void show();


            }
        }
    }
}





}
