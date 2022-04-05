using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Airport
    {
        private static Airport instance = null;
        
        Ticket ticket;
        string name;
        int number_of_seats;
        int number_of_tickets_sold;

        public Airport() { }

        public static Airport getInstance(string name = "airport", int seats = 270, int sold = 250, int cost = 200)
        {
            if (instance == null)
                instance = new Airport(name, seats, sold, cost);
            return instance;
        }

        private Airport(string name = "airport", int seats = 270, int sold = 250, int cost = 200) 
        {
            this.name = name;
            this.number_of_seats = seats;
            this.number_of_tickets_sold = sold;
            this.ticket = new Ticket(cost);
        }

        public void create(string name = "airport", int seats = 270, int sold = 250, int cost = 200)
        {
            instance = getInstance(name, seats, sold, cost);
        }

        public int getPrice()
        {
            return instance.ticket.getPrice();
        }

        public int cost_of_tickets_sold()
        {
            return instance.ticket.getPrice() * number_of_tickets_sold;
        }

        public void increase_price(int inc)
        {
            instance.ticket.increase_price(inc);
        }

        public void decrease_price(int dec)
        {
            instance.ticket.decrease_price(dec);
        }

        public string getName()
        {
            return instance.name;
        }

        public int getNumberOfSeats()
        {
            return instance.number_of_seats;
        }

        public int getNumberOfTicketsSold()
        {
            return instance.number_of_tickets_sold;
        }
    }
}
