using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class VIPTicket : Ticket
    {
        private bool _LoungeAccess { get; set; }
        private decimal _ServiceFee { get; set; } = 50;

        public double _Fee { get; set; }
        public bool _Lounge { get; set; }

        public VIPTicket(string movieName, bool Lounge, double fee, decimal price, bool LoungeAccess) : base(movieName, price)
        {
            _LoungeAccess = LoungeAccess;
            _Fee = fee;
            _Lounge = Lounge;
        }

         public override string ToString() 
        {
            string VIPStutus = _LoungeAccess ? "yes" : "No";
            return base.ToString() + $"Lounge: {_LoungeAccess} | Service Fee: {_ServiceFee}";
        }




        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"Lounge: {_LoungeAccess} | Service Fee: {_ServiceFee} EGP");
        }


        public override void Print()
        {
            Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(_Lounge ? "Yes" : "No")} | Fee: {_Fee} | Price: {Price} | After Tax: {(double)Price + _Fee * 1.14} | Booked: {(IsBooked ? "Yes" : "No")}");
        }



        public override double CalculateFinalPrice() => (double)_Price + _Fee;
    }
}
