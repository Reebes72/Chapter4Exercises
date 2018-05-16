using System;
using System.Collections.Generic;
using System.Text;

namespace DateClass
{
    class Date
    {
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }

        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }

        public void DisplayDate()
        {
            Console.WriteLine(
                $"The date is: " +
                $"{this.Month}/{this.Day}/{this.Year}");
        }
    }
}
