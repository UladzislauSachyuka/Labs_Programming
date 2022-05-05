using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Airport
    {
        private List<Ticket> tickets;
        public Airport()
        {
            tickets = new List<Ticket>(0);
        }
        public void AddTariff(Ticket ticket)
        {
            tickets.Add(ticket);
        }
        public int MaxPrice()
        {
            return tickets.Max(ticket => ticket.get_price());
        }
    }
}
