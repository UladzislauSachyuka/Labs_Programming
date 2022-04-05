using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Ticket
    {
        static int price;

        Ticket() { }

        public Ticket(int pr)
        {
            price = pr;
        }

        public int getPrice()
        {
            return price;
        }

        public void increase_price(int inc)
        {
            price += inc;
        }

        public void decrease_price(int dec)
        {
            price -= dec;
        }
    }
}
