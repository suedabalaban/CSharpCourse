using System;
namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(2, 20);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result3 = Add4(ref number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1); //it has changed because we used ref keyword.

            var result4 = Add5(out number1, number2);
            Console.WriteLine(result4);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 8));

            Console.WriteLine(Add6(2,4 ,5, 1, 8));


        }

        static void Add()
        {
            Console.WriteLine("Added");
        }

        static int Add2(int number1, int number2) 
            //we have to add parameters in paranthesis in order to do algebra.
            //notice the "int" instead of "void" there since we are expecting to get int afterwards.
        {
            var result = number1 + number2;
            return result;
           
        }

        static int Add3(int number1, int number2 = 40)
            //we can also assign a default value to our number but it has to be the end of the paranthesis.
        {
            var result2 = number1 + number2;
            return result2;

        }

        //challenge question
        static int Add4(ref int number1, int number2)
            //we can use ref keyword in order to use number1 as a reference instead of value type(its value has been saved).
            //it has changed in accordance with method
        {
            number1 = 30;
            return number1 + number2;
        }
        //there is an alternative for ref keyword which is "out".
        //the difference is; we must set a value to number1 in ref keyword.
        //we have to set the value in method of out keyword for once.

        static int Add5(out int number1, int number2)
        {
            number1 = 20;
            return number1 + number2;
        }

        //method overloading

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keyword
        //we can send as many parameters as we want to array format with params keyword.
        //params keyword needs to be method's last parameter.
        static int Add6(params int[] numbers)
        {
            return numbers.Sum();
        }

        


    }
}