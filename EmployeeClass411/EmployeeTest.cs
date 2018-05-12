using System;

namespace EmployeeClass411
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Bob", "Builder", 4000m);
            Employee emp2 = new Employee("Dora", "Explorer", 1000m);

            Console.WriteLine(
                $"{emp1.FirstName} the {emp1.LastName} earns {emp1.MonthlySalary} for {emp1.GetYearlySalary()} a year" +
                $"\n Let's give this employee a raise!");
            emp1.GiveRaise();
            Console.WriteLine(
                $"Now {emp1.FirstName} makes {emp1.MonthlySalary} a month and {emp1.GetYearlySalary()} a year\n");

            Console.WriteLine(
                $"{emp2.FirstName} the {emp2.LastName} earns {emp2.MonthlySalary} for {emp2.GetYearlySalary()} a year" +
                $"\n Let's give this employee a raise!");
            emp2.GiveRaise();
            Console.WriteLine(
                $"Now {emp2.FirstName} makes {emp2.MonthlySalary} a month and {emp2.GetYearlySalary()} a year\n");
        }
    }
}
