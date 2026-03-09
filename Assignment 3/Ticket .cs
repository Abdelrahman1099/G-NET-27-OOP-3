using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal abstract class Ticket : IPrintable, IBookable, ICloneable
    {
        private string _MovieName;
        protected decimal _Price;
        public int TicketId { get; private set; }

        private static int _idCounter =0;

        public int idCounter { get; }
        public string MovieName { get { return _MovieName; } set { if (!string.IsNullOrWhiteSpace(value)) _MovieName = value; } }
        public decimal Price { get { return _Price; } set { if (value > 0) _Price = value; } }
        public bool IsBooked { get; private set; }
        public Ticket (string movieName, decimal price)
        {
            _MovieName = movieName;
            _Price = price;
            IsBooked = false;
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
            Console.WriteLine($"Booked: {(IsBooked ? "Yes" : "No")}");
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



        public void Book()
        {
            if (IsBooked)
            {
                Console.WriteLine("Ticket already booked");
            }
            else
            {
                IsBooked = true;
            }
        }

        public void Cancel()
        {
            if (!IsBooked)
            {
                Console.WriteLine("Ticket is not booked");
            }
            else
            {
                IsBooked = false;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {_MovieName} | Price: {_Price}");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }



        public abstract double CalculateFinalPrice();

        public virtual void BookTicket()
        {
            IsBooked = true ;
  
        }

    }
}
