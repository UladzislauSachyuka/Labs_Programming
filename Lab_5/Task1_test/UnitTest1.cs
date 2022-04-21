using Xunit;
using Task1;

namespace Task1_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Airport airport = new Airport();
            airport.AddTicket(new Ticket(200, Ticket.Tariff.Israel));
            airport.AddTicket(new Ticket(100, Ticket.Tariff.Cyprus));
            airport.AddTicket(new Ticket(150, Ticket.Tariff.Egypt));
            airport.AddPassenger("Donald");
            int expected = 450;
            for (int i = 0; i < 3; i++)
            {
                airport.passengers[0].Buy(airport.tickets[i]);
            }
            int actual = airport.passengers[0].GetTotalPrice();
            Assert.Equal(expected, actual);
        }
    }
}