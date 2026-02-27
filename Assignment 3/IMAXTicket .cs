using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class IMAXTicket : Ticket
    {
        private bool _Is3D { get; set; }

        public IMAXTicket(string movieName, decimal price, bool Is3D) : base (movieName, price) 
        {
            _Is3D = Is3D;
            price = Is3D ? price +30 : price;
        }

        public override string ToString()
        {
            string imaxStatus = _Is3D ? "yes" : "No";
            return base.ToString() + $" | IMAX 3D: {imaxStatus}";
        }



        public override void PrintTicket()
        {
            base.PrintTicket();
            Console.WriteLine($"IMAX 3D: {_Is3D}"); 
        }


    }
}
