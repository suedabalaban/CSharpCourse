using System;
using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //classes can be created by different ways.

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Joanna";
            customer.City = "Venice";
            customer.LastName = "Brick";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Rome", FirstName = "Brian",  LastName ="Caller"
            };
            Console.WriteLine(customer2.FirstName);
            



            Console.ReadLine();

        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added");
        }
        public void Update()
        {
            Console.WriteLine("Product Updated");
        }
    }

}