using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Cinema
    {
        public string _CinemaName { get; set; }
        private Ticket[] _tickets;
        private int _ticketsCount = 0;
        private Projector _projector;

        public Cinema(string name)
        {
            _CinemaName = name;
            _projector = new Projector();
            _tickets = new Ticket[20];
        }

        public void AddTicket(Ticket t)
        {
            if (_ticketsCount < 20)
            {
                _tickets[_ticketsCount] = t;
                _ticketsCount++;
            }
            else 
            {
                Console.WriteLine("Cinema is full");
            }
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("======= All Tickets ========");

            for (int i = 0; i < _ticketsCount; i++)
            {
                Console.WriteLine(_tickets[i]);
            }
        }

        public void OpenCinema()
        {
            Console.WriteLine($"======== {_CinemaName} Opened ==========");
            _projector.Start();
        }


        public void CloseCinema()
        {
            Console.WriteLine($"======== {_CinemaName} Closed ==========");
            _projector.close();
        }


    }
}
