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

            #region 

            //Cinema myCinema = new Cinema("cinema");
            //myCinema.OpenCinema();

            //Console.WriteLine("========== SetPrice Test ==========");

            //StandardTicket t1 = new StandardTicket("Inception", 150, "(A, 5)");
            //VIPTicket t2 = new VIPTicket("Avengers", 200, true);
            //IMAXTicket t3 = new IMAXTicket("Dune", 180, false);

            //t1.SetPrice(150);
            //t1.SetPrice(100, 1.5m);

            //myCinema.AddTicket(t1);
            //myCinema.AddTicket(t2);
            //myCinema.AddTicket(t3);

            //myCinema.PrintAllTickets();

            //Cinema.ProcessTicket(t2);
            //myCinema.CloseCinema();

            #endregion


            // Assignment 5


            #region 

            // Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly? Mention at least three benefits of using interfaces.

            // An interface in C# is a contract that defines methods and properties without implementation. Any class that implements the interface must provide the implementation.
            // We use interfaces instead of concrete classes because they make the code more flexible and maintainable
            // Benefits: Loose coupling - Supports polymorphism - Multiple Implementation

            #endregion

            #region 

            // Q2 : Look at the following code and answer the questions below:

            // a) The issue is that both interfaces define a method with the same signature,
            // Currently, the class uses one shared implementation, so both interfaces behave the same and cannot have different greetings.

            // b) We solve it using Explicit Interface Implementation,
            // which allows each interface to have its own separate Greet() method implementation.

            // You cannot call translator.Greet() directly, because explicit interface methods are only accessible through the interface not the class, You must use an interface reference.
            #endregion

            #region 

            // Q3 : Explain the difference between a shallow copy and a deep copy.
            // When would you use each one? What is the risk of using a shallow copy when the object has reference-type fields?

            // Shallow Copy : Copies the object, but reference-type fields still point to the same objects in memory.
            // We use Shallow Copy for simple objects or when shared references are acceptable.

            // Deep Copy : Copies the object and also creates new copies of all referenced objects.
            // We use Deep Copy when you need full independence between objects.

            // If the object has reference-type fields, both copies share the same internal objects. Modifying one will affect the other, which can cause unexpected bugs.


            #endregion

            #region 

            // Q4 : Look at the following code and determine the output. Explain why.

            // Dev - Testing
            // QA - Testing

            // This is a Shallow Copy, value-type fields are copied but Reference-type fields share the same object.
            // That’s why modifying Dept.Name affected both objects.

            #endregion

            #region 

            //Cinema cinema = new Cinema("cinema");
            //cinema.OpenCinema();

            //StandardTicket tic1 = new StandardTicket( "Inception", 80, "A5");
            //VIPTicket tic2 = new VIPTicket("Avengers ", true, 50, 200, true);
            //IMAXTicket tic3 = new IMAXTicket("Dune", 130, true);

            //Console.WriteLine("--- All Tickets ---");

            //tic1.Print();
            //tic2.Print();
            //tic3.Print();

            //Console.WriteLine("--- Clone Test ---");

            //Console.Write("Original : ");
            //tic2.Print();

            //VIPTicket tic4 = (VIPTicket)tic2.Clone();
            //tic4.MovieName = "Interstellar";
            //tic4.Cancel();
            //Console.Write("Clone    : ");
            //tic4.Print();

            //Console.WriteLine("--- After Cancellation ---");
            //tic1.Cancel(); 
            //tic1.Print();

            //Console.WriteLine("--- BookingHelper.PrintAll ---");

            //IPrintable[] tickets = { tic1, tic2, tic3 };
            //BookingHelper.printAll(tickets);

            //cinema.CloseCinema();

            #endregion


            // Assignment 6

            #region 

            // Q1 : What is abstraction in OOP? How is it different from encapsulation?
            // Give a real-world example (not from the session) that shows the difference between the two.

            // Abstraction means hiding complex implementation details and showing only the essential features of an object.
            // It focuses on what the object does rather than how it works internally. On the other hand, encapsulation means wrapping data and methods together in a single class and restricting direct access to the data to protect it.
            // The main difference is that abstraction hides complexity, while encapsulation protects data and controls access to it.
            // A real-world example is an ATM machine. When a user withdraws money,
            // they only interact with the screen and buttons without knowing how the banking system processes the transaction internally

            #endregion

            #region 

            // Q2 : What is the difference between an abstract class and an interface? Give at least four differences.
            // When would you choose one over the other?

            // abstract class can have both abstract methods and normal methods with implementation,
            // while an interface usually contains only abstract methods.
            // A class can inherit from only one abstract class,
            // but it can implement multiple interfaces.,
            // an abstract class can have instance variables and constructors,
            // while an interface mainly contains constants and does not have constructors.
            // We use an abstract class when related classes share common code and behavior,
            // while we use an interface when different classes need to follow the same set of methods.

            #endregion

            #region 

            // Q3 : Look at the following code and answer the questions below:

            // a) No, you cannot write Appliance a = new Appliance("LG"); because Appliance is an abstract class.
            // b) PowerConsumption() is abstract because each appliance has a different power usage.
            // Status() is virtual which means it has a default implementation ("Standby") but can be overridden by subclasses if needed.
            // Label() is a concrete method because it already has a full implementation that works for all appliances.
            // c) If you call Status() on a Toaster object, it will return "Standby" because the Toaster class does not override the method.

            #endregion

            #region 

            // Q4 : Look at the following code and answer the questions below:

            // a) partial class is a class whose definition can be split across multiple files, but all parts are combined into a single class during compilation.
            // A developer may split the Calculator class into two files to improve code organization and maintainability.
            // b) partial method is a method that is declared in one part of a partial class and can be implemented in another part of the same class.
            // If the implementation of OnCalculated() in Calculator.Logging.cs is deleted, the code will still compile successfully.
            // This is because partial methods are optional, and if no implementation is provided, the compiler simply removes the method call during compilation.
            // c) extension method allows you to add new methods to an existing type without modifying its original definition or creating a subclass.
            // The three rules for writing an extension method are:
            // 1- The method must be inside a static class.
            // 2- The method itself must be static.
            // 3- The first parameter of the method must be preceded by the keyword this.
            // d) "$20.00"

            #endregion

            #region 

            Cinema myCinema = new Cinema("Cinema");
            myCinema.OpenCinema();

            // Ticket t = new Ticket("Test", 100); // ERROR: Cannot create instance of abstract type

            Ticket t1 = new StandardTicket("Inception", 80, "A5");
            Ticket t2 = new VIPTicket("Avengers", true, 20.00, 200, true);
            Ticket t3 = new IMAXTicket("Dune", 130, true);

            t1.BookTicket();
            t2.BookTicket();
            t3.BookTicket();

            myCinema.AddTicket(t1);
            myCinema.AddTicket(t2);
            myCinema.AddTicket(t3);
            myCinema.PrintAllTickets();

            Ticket[] tickets = {t1, t2, t3};
            Console.WriteLine("--- Polymorphism: Final Price per Ticket ---");

            foreach (var t in tickets)
            {
                Console.WriteLine($"{t.GetType().Name} => Final Price: {t.CalculateFinalPrice():F2}");
            }

            Console.WriteLine("--- Extension Method: Receipt ---");
            t2.GenerateReceipt();

            Console.WriteLine("--- Extension Method: Total Revenue ---");
            Console.WriteLine($"Total Revenue: {tickets.CalculateTotalRevenue()}");

            myCinema.CloseCinema();

            #endregion

        }
    }
} 
