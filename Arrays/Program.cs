using System;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //there are different ways of creating an array.

            string[] students = new string[3];
            students[0] = "Anna";
            students[1] = "Steven";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[] students2 = { "Adam ", "Spencer", "Hazel",};
            
            string[] students3 = new[] { "Lisa", "Marie", "Annie" };

            //multi dimensional arrays

            //string[,] regions = new string[7, 3];
            //regions[0, 0] = "İstanbul";
            
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","Edirne","Bursa" },
                {"Ankara", "Konya","Sivas"},
                {"Antalya","Adana","Mersin"},
                {"Trabzon","Samsun","Rize"},
                {"İzmir","Aydın","Muğla"},
            };

            //rows are dimension 0, columns are dimension 1.
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("*******");
            }



            



        }
    }
}