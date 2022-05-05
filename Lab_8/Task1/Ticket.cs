using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Ticket
    {
        private IPrice price;
        private string tariff;
        public Ticket(int pr, string tar)
        {
            price = new NoDiscount(pr);
            tariff = tar;
        }
        public Ticket(int pr, int dis, string tar)
        {
            price = new AbsDiscount(pr, dis);
            tariff = tar;
        }
        public int get_price()
        {
            return price.get_price();
        }
    }
}
