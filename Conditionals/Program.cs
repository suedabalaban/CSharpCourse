using System;
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }
            Console.ReadLine();


            //second way -- Single Line If

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
            //if its true    if its not true

            //switch

            var number2 = 12;
            switch (number2)
            {
                case 10:
                    Console.WriteLine("Number2 is 10");
                    break;
                case 20:
                    Console.WriteLine("Number2 is 20");
                    break;
                default:
                    Console.WriteLine("Number2 is not 10 or 20");
                    break;
            }

            var number3 = Convert.ToInt32(Console.ReadLine());

            if (number3 >= 0 && number3 <= 100)
            {
                Console.WriteLine("Number3 is between 0-100");
            }
            else if (number3 > 100 && number3 <= 200)
            {
                Console.WriteLine("Number3 is between 101-200");
            }
            else if (number3 > 200 || number3 < 0)
            {
                Console.WriteLine("Number3 is less than zero or greater than 200");
            }

            var number4 = Convert.ToInt32(Console.ReadLine());
            if (number4 < 100)
            {
                if (number >= 90 && number < 95)
                {
                    Console.WriteLine("Number4 is between 90 and 95");
                }
                else
                {
                    Console.WriteLine("Number4 is not between 90 and 95");
                }
            }


        }
    }
}