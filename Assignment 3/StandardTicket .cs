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
        public StandardTicket(string movieName, decimal price, string seatNumber) : base (movieName, price)
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


        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat: {_SeatNumber} | Price: {_Price} | After Tax: {_Price * 1.14m} | Booked: {(IsBooked ? "Yes" : "No")}");
        }


        public override double CalculateFinalPrice() => (double)_Price * 1.14;

    }
}
