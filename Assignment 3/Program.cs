namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Cinema cinema = new Cinema("cinema");
            cinema.OpenCinema();

            StandardTicket ticket1 = new StandardTicket("Inception", 120, "A-5");
            VIPTicket ticket2 = new VIPTicket("Avengers", 200, true);
            IMAXTicket ticket3 = new IMAXTicket("Dune", 180, false);

            cinema.AddTicket(ticket1);
            cinema.AddTicket(ticket2);
            cinema.AddTicket(ticket3);

            cinema.PrintAllTickets();

            Console.WriteLine("======== Statistics ========");
            Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            cinema.CloseCinema();
        }
    }
}
