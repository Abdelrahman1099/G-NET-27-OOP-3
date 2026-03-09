using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
            //Console.WriteLine("======= All Tickets ========");

            for (int i = 0; i < _ticketsCount; i++)
            {
                _tickets[i].PrintTicket();
            }
        }
    }
}
