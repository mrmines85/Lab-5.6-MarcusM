using System;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;

        }
        static void Main(string[] args)
        {
            Customer customerA = new Customer();
            Customer customerB = new Customer();
            Customer customerC = new Customer();

            customerA.first_name = "Ginyu";
            customerA.last_name = "The body snatcher";
            customerA.age = 16;
            customerA.hasMembership = false;

            customerB.first_name = "Goku";
            customerB.last_name = "That clown Kakarot";
            customerB.age = 25;
            customerB.hasMembership = false;

            customerC.first_name = "Vegeta";
            customerC.last_name = "The Prince of all Saiyans";
            customerC.age = 30;
            customerC.hasMembership = true;

            Customer[] Customers = { customerA, customerB, customerC };

            for (int x = 0; x < Customers.Length; x++)
            {
                if (Customers[x].age < 21)
                {
                    Console.WriteLine(Customers[x].first_name + " " + Customers[x].last_name + " is not allowed to place an order");
                }
                else
                {
                    Console.WriteLine(Customers[x].first_name + " " + Customers[x].last_name + " can place an order");
                }

                if (Customers[x].hasMembership == true)
                {
                    Console.WriteLine(Customers[x].first_name + " " + Customers[x].last_name + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(Customers[x].first_name + " " + Customers[x].last_name + " is a standard member.");
                }
            }
        }
    }
}
