using System;
using System.Runtime.CompilerServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //we use loops to iterate data frames.

            //we can print out double numbers or simply the numbers between 1-100.

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Finished");

            for (int i = 1; i <= 100; i++) //++ means increasing by one.
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }

            //another way of printing double or singular numbers.
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }

            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--; //if we dont add this code, this block will cause infinite loop.

            }
            Console.WriteLine("Now number is {0}", number);

            //do while loop

            int number2 = 10;
            do
            {
                Console.WriteLine(number2);
                number2--;
            } while (number2 >= 11);

            //foreach loop--used for iterating array based data.

            string[] students = { "Alias", "Reese", "John" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //example code

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }

            Console.ReadLine();

        }

        //example application to sum all topics---Prime Numbers

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i == 0)
                {
                    result = false;
                    i = number;
                }
            }
            return result;
        }
    }
}