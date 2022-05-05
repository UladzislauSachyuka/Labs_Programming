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
            Ticket ticket = new Ticket(200, 50, "Moscow");
            Assert.Equal(100, ticket.get_price());
        }

        [Fact]
        public void Test2()
        {
            Airport airport = new Airport();
            Ticket ticket = new Ticket(200, 50, "Moscow");
            airport.AddTariff(ticket);
            Ticket ticket1 = new Ticket(300, "Tel-Aviv");
            airport.AddTariff(ticket1);
            Ticket ticket2 = new Ticket(500, "New York");
            airport.AddTariff(ticket2);
            Assert.Equal(500, airport.MaxPrice());
        }
    }
}