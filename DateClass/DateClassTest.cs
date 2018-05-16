using System;

namespace DateClass
{
    class DateClassTest
    {
        static void Main(string[] args)
        {
            Date date1 = new Date(12, 1, 2018);
            Date date2 = new Date(7, 4, 1776);

            date1.DisplayDate();
            date2.DisplayDate();
        }
    }
}
