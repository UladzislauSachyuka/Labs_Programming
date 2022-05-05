using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket = new Ticket(100, 20, "Israel");
            Airport airport = new Airport();
            airport.AddTariff(ticket);
            Console.WriteLine(airport.MaxPrice());
        }
        
    }
}