using System;

namespace ComputerizationOfHealthRecords415
{
    class HealthProfileTest
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
                "What is your gender?");
            string gender = Console.ReadLine();

            Console.WriteLine(
                "Date of birth? (XX/XX/XXXX)");
            string _birth = Console.ReadLine();
            string[] birth = _birth.Split("/");

            Console.WriteLine(
                "Height in inches.");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "Weight in pounds.");
            int weight = int.Parse(Console.ReadLine());

            HealthProfile patient = new HealthProfile(first, last, gender, int.Parse(birth[0]), int.Parse(birth[1]), int.Parse(birth[2]), height, weight);
        }
    }
}
