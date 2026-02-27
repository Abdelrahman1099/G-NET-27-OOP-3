using System.Net.Sockets;

namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Cinema cinema = new Cinema("cinema");
            //cinema.OpenCinema();

            //StandardTicket ticket1 = new StandardTicket("Inception", 120, "A-5");
            //VIPTicket ticket2 = new VIPTicket("Avengers", 200, true);
            //IMAXTicket ticket3 = new IMAXTicket("Dune", 180, false);

            //cinema.AddTicket(ticket1);
            //cinema.AddTicket(ticket2);
            //cinema.AddTicket(ticket3);

            //cinema.PrintAllTickets();

            //Console.WriteLine("======== Statistics ========");
            //Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTickets()}");

            //cinema.CloseCinema();




            // Assignment 4



            #region 

            // Q1 : What is the difference between static binding and dynamic binding? When does each one happen?

            // Static Binding happens at compile time, Happens with Method Overloading and Non-virtual methods. Dynamic Binding happens at runtime,
            // where the method is determined based on the actual object type sually when using virtual and override methods in method overriding.

            #endregion

            #region 

            // Q2 :  What is the difference between method overloading and method overriding?

            // Overloading happens when you have multiple methods in the same class with the same name, but different "signatures".
            // Method Overriding means redefining a method in a derived class that already exists in the base class using virtual and override.

            #endregion

            #region 

            // virtual - Used in the base class. It allows the method to be overridden.
            // override - Used in the derived class. It redefines the base class method.

            #endregion

            Cinema myCinema = new Cinema("cinema");
            myCinema.OpenCinema();

            Console.WriteLine("========== SetPrice Test ==========");

            StandardTicket t1 = new StandardTicket("Inception", 150, "(A, 5)");
            VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

            t1.SetPrice(150);
            t1.SetPrice(100, 1.5m);

            myCinema.AddTicket(t1 );
            myCinema.AddTicket(t2 );
            myCinema.AddTicket(t3 );

            myCinema.PrintAllTickets();

            Cinema.ProcessTicket(t2);
            myCinema.CloseCinema();


            #region 


            #endregion
        }
    }
} 
