using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class DateService
    {
        public static String GetDay(String date)
        {
            DateTime dateValue = DateTime.Parse(date);
            return dateValue.ToString("dddd");
        }

        public static int GetDaysSpan(int day, int month, int year, int day1, int month1, int year1)
        {
            TimeSpan span = new DateTime(year, month, day) - new DateTime(year1, month1, day1);
            return span.Days;
        }
    }
}
