using System;

namespace SquareOfAsterisks530
{
    class AsterisksSquare
    {
        static void Main(string[] args)
        {
            string[,] square;

            Console.WriteLine(
                "This program will create a square of asterisks of a size between 1-20 that you specify.\n" +
                "Please enter a number between 1-20");

            int number = int.Parse(Console.ReadLine());

            if( number > 20)
            {
                number = 20;
            }
            if(number < 1)
            {
                number = 1;
            }

            square = new string[number, number];

            for(int i = 0; i < square.GetLength(0); i++)
            {
                for(int j = 0; j < square.GetLength(1); j++)
                {
                    Console.Write(i == 0 || i+1 == square.GetLength(0) || j == 0 || j+1 == square.GetLength(1) ? "*" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
