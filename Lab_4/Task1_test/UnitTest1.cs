//using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Airport airport = Airport.getInstance("air", 250, 200, 100);

            Assert.Equal("air", airport.getName());
        }

        [Fact]
        public void Test2()
        {
            Airport airport = Airport.getInstance("air", 250, 200, 100);

            Assert.Equal(250, airport.getNumberOfSeats());
        }

        [Fact]
        public void Test3()
        {
            Airport airport = Airport.getInstance("air", 250, 200, 100);

            Assert.Equal(200, airport.getNumberOfTicketsSold());
        }

        [Fact]
        public void Test4()
        {
            Airport airport = Airport.getInstance("air", 250, 200, 100);

            Assert.Equal(100, airport.getPrice());
        }

        [Fact]
        public void Test5()
        {
            Airport airport = Airport.getInstance("air", 250, 200, 100);

            Assert.Equal(20000, airport.cost_of_tickets_sold());
        }
    }
}