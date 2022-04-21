using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Airport
    {
        public List<Passenger> passengers;
        public List<Ticket> tickets;

        public Airport() 
        {
            passengers = new List<Passenger>();
            tickets = new List<Ticket>();
        }
        public void AddPassenger(string name)
        {
            passengers.Add(new Passenger(name));
        }
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public void AddTicket(int Price, Ticket.Tariff Tariff)
        {
            tickets.Add(new Ticket(Price, Tariff));
        }
        public void BuyTicket(string passenger_name, Ticket.Tariff tariff, int price)
        {
            foreach (Passenger current_passenger in passengers)
            {
                if (current_passenger.Name == passenger_name)
                {
                    foreach (Ticket current_ticket in tickets)
                    {
                        if (current_ticket.Type == tariff)
                        {
                            if (current_ticket.Price == price)
                            {
                                current_passenger.Buy(current_ticket);
                                return;
                            }
                        }
                    }
                    AddTicket(price, tariff);
                    current_passenger.Buy(tickets.Last());
                    return;
                }
            }
            AddPassenger(passenger_name);
            BuyTicket(passenger_name, tariff, price);
            return;
        }
        public void PrintInfo(string passenger_name)
        {
            foreach(Passenger current_passenger in passengers)
            {
                if (current_passenger.Name == passenger_name)
                {
                    if (current_passenger.Tickets.Count == 0)
                    {
                        Console.WriteLine("\n################################\n");
                        Console.WriteLine("{0} has no tickets", current_passenger.Name);
                        Console.WriteLine("\n################################\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\n################################\n");
                        Console.WriteLine("{0} has {1} tickets:", current_passenger.Name, current_passenger.Tickets.Count);
                        foreach (Ticket current_ticket in current_passenger.Tickets)
                        {
                            Console.WriteLine("{0} - {1}", current_ticket.Type, current_ticket.Price);
                        }
                        Console.WriteLine("\n################################\n");
                        return;
                    }
                }
            }
            Console.WriteLine("Passenger not found");
            return;
        }
        public void PrintTotalPrice(string passenger_name)
        {
            foreach (Passenger current_passenger in passengers)
            {
                if (current_passenger.Name == passenger_name)
                {
                    if (current_passenger.Tickets.Count == 0)
                    {
                        Console.WriteLine("\n################################\n");
                        Console.WriteLine("{0} has no tickets", current_passenger.Name);
                        Console.WriteLine("\n################################\n");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\n################################\n");
                        Console.WriteLine("Total price: {0}", current_passenger.GetTotalPrice());
                        Console.WriteLine("\n################################\n");
                        return;
                    }
                }
            }
            Console.WriteLine("Passenger not found");
            return;
        }
        public void PrintTickets()
        {
            Console.WriteLine("\n################################\n");
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine("{0} - {1}", ticket.Type, ticket.Price);
            }
            Console.WriteLine("\n################################\n");
        }
        public void PrintPassengers()
        {
            Console.WriteLine("\n################################\n");
            foreach (Passenger passenger in passengers)
            {
                Console.WriteLine("{0}", passenger.Name);
            }
            Console.WriteLine("\n################################\n");
        }
        public void BuyTicket(string passenger_name, string type)
        {
            Ticket.Tariff tariff = (Ticket.Tariff) Enum.Parse(typeof(Ticket.Tariff), type);
            foreach (Passenger curent_passenger in passengers)
            {
                if (curent_passenger.Name == passenger_name)
                {
                    foreach (Ticket current_ticket in tickets)
                    {
                        if (current_ticket.Type == tariff)
                        {
                            curent_passenger.Buy(current_ticket);
                            return;
                        }
                    }
                    Console.WriteLine("Ticket not found");
                    Console.WriteLine("Enter the price: ");
                    AddTicket(Convert.ToInt32(Console.ReadLine()), tariff);
                    curent_passenger.Buy(tickets.Last());
                    return;
                }
            }
            AddPassenger(passenger_name);
            BuyTicket(passenger_name, type);
            return;
        }

    }
}
