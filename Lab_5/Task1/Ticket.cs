using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Ticket
    {
        /*int cost_of_all_tickets_sold;

        public Ticket(int cost_sold, string name, int cost)
        {
            passenger = new Passenger(name, cost);
            cost_of_all_tickets_sold = cost_sold;
        }
        public int get_cost_of_all_ticket_sold()
        {
            return cost_of_all_tickets_sold;
        }*/

        private int price;

        public enum Tariff
        {
            Israel,
            Cyprus,
            Egypt
        }
        Tariff type;

        public Ticket()
        {
            price = 100;
            type = Tariff.Israel;
        }
        public Ticket(int pr, Tariff t)
        {
            Price = pr;
            type = t;
        }
        public int Price
        {
            get { return price; }

            set 
            {
                if (value < 0)
                {
                    price = 100;
                    return;
                }
                price = value; 
            }
        }

        public Tariff Type 
        { 
            get { return type; } 
            set { type = value; }
        }
    }
}
