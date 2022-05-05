using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class AbsDiscount : IPrice
    {
        private int price = 0;
        private int discount = 0;
        public AbsDiscount(int pr, int dis)
        {
            price = pr - pr * dis / 100;
            discount = dis;
        }
        public int get_price()
        {
            return price;
        }
    }
}
