using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Ticket
    {
        private string _MovieName;
        private decimal _Price;
        public int TicketId { get; private set; }

        private static int _idCounter =0;

        public int idCounter { get; }
        public string MovieName { get { return _MovieName; } set { if (!string.IsNullOrWhiteSpace(value)) _MovieName = value; } }
        public decimal Price { get { return _Price; } set { if (value > 0) _Price = value; } }
        public Ticket (string movieName, decimal price)
        {
            _MovieName = movieName;
            _Price = price;

            _idCounter++;
            TicketId = _idCounter;

        }
        public decimal PriceAfterTax => Price * 1.14m;

        public override string ToString()
        {
            return $"Ticket #{TicketId} | {_MovieName} | price: {_Price} EGP | After Tax: {PriceAfterTax} EGP";
        }

        public static int GetTotalTickets() => _idCounter;





        public virtual void PrintTicket()
        {
            Console.WriteLine($"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP");
        }


        public void SetPrice(decimal price) 
        {
            _Price = price;
            Console.WriteLine($"Setting price directly: {_Price}");
        }


        public void SetPrice(decimal basePrice, decimal multiplier)
        {
            _Price = (basePrice * multiplier);

            Console.WriteLine($"Setting price with multiplier: {basePrice} x {multiplier} = {_Price}");
        }


    }
}
