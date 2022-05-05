using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class NoDiscount : IPrice
    {
        private int price = 0;
        public NoDiscount(int pr)
        {
            price = pr;
        }
        public int get_price()
        {
            return price;
        }
    }
}
