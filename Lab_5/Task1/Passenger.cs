using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Passenger
    {
        private string name;
        public Passenger(string name_)
        {
            name = name_;
            Tickets = new List<Ticket>();
        }

        public void Buy(Ticket.Tariff Type, int Price)
        {
            Tickets.Add(new Ticket(Price, Type));
            return;
        }
        public void Buy(Ticket ticket)
        {
            Tickets.Add(ticket);
            return;
        }
        public int GetTotalPrice()
        {
            int TotalPrice = 0;
            foreach (Ticket Ticket in Tickets)
            {
                TotalPrice += Ticket.Price;
            }
            return TotalPrice;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    name = "David Beckham";
                    return;
                }
                name = value;
            }
        }

        private List<Ticket> tickets;
        public List<Ticket> Tickets
        {
            get { return tickets; }
            set { tickets = value; }
        }
    }
}
