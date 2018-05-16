using System;
using System.Collections.Generic;
using System.Text;

namespace TargetHeartRateCalculator414
{
    class HeartRates
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int birthYear;
        private int currentYear;

        public int Age
        {
            get
            {
                return CurrentYear - BirthYear;
            }
        }

        public int BirthYear
        {
            get { return birthYear; }
            private set
            {
                if (value < int.Parse(DateTime.Now.Year.ToString()) && value > 1900)
                {
                    birthYear = value;
                } else
                {
                    Console.WriteLine("Invalid entry. Defaulting to 1900");
                    birthYear = 1900;
                }
            }
        }

        public int CurrentYear
        {
            get { return currentYear; }
            private set
            {
                if(value == int.Parse(DateTime.Now.Year.ToString()))
                {
                    currentYear = value;
                }
            }
        }

       public HeartRates(string first, string last, int birthYear)
        {
            FirstName = first;
            LastName = last;
            BirthYear = birthYear;
            CurrentYear = int.Parse(DateTime.Now.Year.ToString());

        }

        public int MaxHeartRate
        {
            get
            {
                return 220 - Age;
            }
            
        }

        public double TargetMinimumRate
        {
            get
            {
                return MaxHeartRate * 0.5;
            }
        }

        public double TargetMaxRate
        {
            get
            {
                return MaxHeartRate * 0.85;
            }
        }

        public void DisplayVitals()
        {
            Console.WriteLine(
                "\nCalculations based upon the data entered.\n");

            Console.WriteLine(
                $"Patient Name:     {FirstName} {LastName}\n" +
                $"Age:              {Age}\n" +
                $"Max Heart Rate:   {MaxHeartRate}\n" +
                $"Heart Rate Range: {TargetMinimumRate} - {TargetMaxRate}\n");
        }
    }
}
