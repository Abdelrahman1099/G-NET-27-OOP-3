using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class StandardTicket : Ticket
    {
        public string _SeatNumber { get; set; } 
        public StandardTicket(string movieNAme, decimal price, string seatNumber) : base (movieNAme, price)
        {
            _SeatNumber = seatNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $" | Seat: {_SeatNumber}";
        }



        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Seat: {_SeatNumber}");
        }

    }
}
