using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot(),
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eaters = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var eat in eaters)
            {
                eat.Eat();
            }
            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
        }

    }

    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("The eating time has been opened for Manager.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Salary has been specified for Manager.");
        }

        public void Work()
        {
            Console.WriteLine("Working schedule has been specified for Manager.");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("The eating time has been opened for Worker.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Salary has been specified for Worker.");
        }

        public void Work()
        {
            Console.WriteLine("Working schedule has been specified for Worker.");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working schedule has been specified for Robot.");
        }
    }
}
