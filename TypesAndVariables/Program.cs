using System;
namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types

            int number1 = 10; //32 bit
            //int boundaries: -2147483648 to 2147483647
            int number2 = 2147483647;
            Console.WriteLine("Number1 is {0}, Number2 is {1}", number1, number2);

            //long holds 2x more memory in ram than int
            long number3 = 2147483648; //64 bit
            //long boundaries: -9223372036854775808 to 9223372036854775807
            Console.WriteLine("Number3 is:" + number3);

            short number4 = 1; //16 bit
            //short boundaries:-32768 to 32767
            Console.WriteLine("Number4 is:" + number4);

            byte number5 = 4; //8 bit
            //byte boundaries: 0 to 255
            Console.WriteLine("Number5 is {0}", number5);

            bool condition = true;
            //takes true or false - logical value type
            Console.WriteLine(condition);

            char character = 'A';
            Console.WriteLine("Character is {0}", (int)character);
            //char can be turned into int

            double number6 = 10.4; //64 bit
            //double can hold decimal numbers
            Console.WriteLine("Number6 is {0}", number6);

            decimal number7 = 6.54m;
            //decimal holds 2x more numbers in ram than double
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine((int)Days.Friday);

            var number8 = 10;
            number8 = 'A';
            Console.WriteLine("Number8 is {0}", number8);

        }

        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }                         
    }
}
