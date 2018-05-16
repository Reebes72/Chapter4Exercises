using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerizationOfHealthRecords415
{
    class HealthProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }
        public int BirthYear { get; set; }
        public int HeightInches { get; set; }
        public int WeightPounds { get; set;}

        public HealthProfile (string first, string last, string gender, int month, int day, int year, int height, int weight)
        {
            FirstName = first;
            LastName = last;
            Gender = gender;
            BirthMonth = month;
            BirthDay = day;
            BirthYear = year;
            HeightInches = height;
            WeightPounds = weight;
            DisplayBMIValues();
            DisplayVitals();
        }

        public double BMI
        {
            get { return (WeightPounds * 703) / (HeightInches * HeightInches); }
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
        public int Age
        {
            get
            {
                return int.Parse(DateTime.Now.Year.ToString()) - BirthYear;
            }
        }
        public string BirthDate
        {
            get
            {
                return BirthMonth + "/" + BirthDay + "/" + BirthYear;
            }
        }

        public static void DisplayBMIValues()
        {
            Console.WriteLine(
                "Guidelines set down for proper BMI.\n");
            Console.WriteLine(
                "BMI Values");
            Console.WriteLine(
                "Underweight: less than 18.5");
            Console.WriteLine(
                "Normal:      between 18.5 and 24.9");
            Console.WriteLine(
                "Overweight:  between 25 and 29.9");
            Console.WriteLine(
                "Obese:       30 or greater\n");
        }

        public void DisplayVitals()
        {
            Console.WriteLine(
                "\nCalculations based upon the data entered.\n");

            Console.WriteLine(
                $"Patient Name:     {FirstName} {LastName}\n" +
                $"DOB:              {BirthDate}\n" +
                $"Gender:           {Gender}\n" +
                $"Height:           {HeightInches} inches\n" +
                $"Weight:           {WeightPounds} pounds\n" +
                $"BMI:              {BMI}%\n" +
                $"Max Heart Rate:   {MaxHeartRate}\n" +
                $"Heart Rate Range: {TargetMinimumRate} - {TargetMaxRate}\n");
        }
    }
}
