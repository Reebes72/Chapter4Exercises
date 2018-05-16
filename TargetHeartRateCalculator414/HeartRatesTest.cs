using System;

namespace TargetHeartRateCalculator414
{
    class HeartRatesTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Enter your first name.");
            string first = Console.ReadLine();

            Console.WriteLine(
                "Enter your last name.");
            string last = Console.ReadLine();

            Console.WriteLine(
                "What year were you born?");
            int birthYear = int.Parse(Console.ReadLine());

            HeartRates patient = new HeartRates(first, last, birthYear);
            patient.DisplayVitals();
        }
    }
}
