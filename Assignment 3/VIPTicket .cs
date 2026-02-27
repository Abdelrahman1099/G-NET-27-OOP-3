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

        public VIPTicket(string movieName, decimal price, bool LoungeAccess) : base(movieName, price)
        {
            _LoungeAccess = LoungeAccess;
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
    }
}
