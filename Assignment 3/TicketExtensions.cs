using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal static class TicketExtensions
    {
        public static void GenerateReceipt(this Ticket ticket)
        {
            Console.WriteLine("========= RECEIPT =========");
            Console.WriteLine($" Movie   : {ticket.MovieName}");
            Console.WriteLine($" Type    : {ticket.GetType().Name}");
            Console.WriteLine($" Price   : {ticket.Price}");
            Console.WriteLine($" Final   : {ticket.CalculateFinalPrice()}");
            Console.WriteLine($" Status  : {(ticket.IsBooked ? "Booked" : "Available")}");
            Console.WriteLine("===========================");
        }

        public static double CalculateTotalRevenue(this Ticket[] tickets)
        {
            double totalRevenue = 0;
            foreach (var ticket in tickets)
            {
                totalRevenue += ticket.CalculateFinalPrice();
            }

            return totalRevenue;

        }
    }
}
