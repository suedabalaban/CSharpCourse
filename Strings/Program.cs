using System;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            string city = "Ankara";
            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            //printing two strings together without using extra code:
            Console.WriteLine(String.Format("{0} {1}", city, city2));

            string sentence = "My name is Giovanni Giorgio";

            var result = sentence.Length; //it counts space as character as well.
            Console.WriteLine(result);

            var result2 = sentence.Clone(); //this method creates a clone of string.

            sentence = "My name is Gwen Stacy";
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("ğ"); //checking whether the condition is true or false in paranthesis.
            Console.WriteLine(result3);

            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("name"); //using for searching specified character or item.
            Console.WriteLine(result5); //returns -1 when character cannot be spotted.

            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6); //returns the first result it find and stop after.

            var result7 = sentence.LastIndexOf(" "); //starts searching from the end.

            var result8 = sentence.Insert(0, "Hello, "); //using for adding another text to a string.

            var result9 = sentence.Substring(3, 4); //using for dividing a string.
            Console.WriteLine(result9); //took 4 character after 3 index.

            var result10 = sentence.ToLower(); //changes all the characters into lowercase letters.
            Console.WriteLine(result10);

            var result11 = sentence.ToUpper(); //does the opposite of tolower method.

            var result12 = sentence.Replace(" ", "-"); //changes spesific characters onto something else.

            var result13 = sentence.Remove(2, 4); //removing certain part of string after specified index.
            Console.WriteLine(result13);





        }
    }
}