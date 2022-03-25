using Xunit;
using System;
using static Task3.DateService;

namespace Task3_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //int day = DateTime.UtcNow.Day;
            //int month = DateTime.UtcNow.Month;
            //int year = DateTime.UtcNow.Year;
            string date1 = DateTime.UtcNow.Date.ToString();
            string date2 = DateTime.UtcNow.Date.ToString("dddd");
            Assert.Equal(GetDay(date1), date2); 
        }

        [Fact]
        public void Test2()
        {
            int expected = 200;
            int result = GetDaysSpan(10, 10, 2022, 24, 03, 2022);
            Assert.Equal(expected, result);
        }
    }
}