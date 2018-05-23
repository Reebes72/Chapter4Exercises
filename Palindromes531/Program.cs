using System;

namespace Palindromes531
{
    class Program
    {
        static void Main(string[] args)
        {
            string input ="";
            while (input.Length < 5 || input.Length > 5)
            {
                Console.WriteLine(
                    "Please enter a 5 digit integer.");
                input = Console.ReadLine();
            }

            
               int  palindrome = int.Parse(input);
            



            int temp = palindrome;
            int temp1, temp2, temp4, temp5;

            temp5 = palindrome % 10;
            palindrome /= 10;
            temp4 = palindrome % 10;
            palindrome /= 100;
            temp2 = palindrome % 10;
            palindrome /= 10;
            temp1 = palindrome;

            if(temp1 == temp5 && temp2 == temp4)
            {
                Console.WriteLine(
                    $"{temp} is a palindrome.");
            }
            else
            {
                Console.WriteLine(
                    $"{temp} is not a palindrome.");
            }


            
        }
    }
}
