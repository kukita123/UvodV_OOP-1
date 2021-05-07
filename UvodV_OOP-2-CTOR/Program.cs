using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodV_OOP_2_CTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);
            Console.WriteLine();

            Customer customer1 = new Customer(1);
            Console.WriteLine(customer1.ID);
            customer.Name = "Mariana";
            Console.WriteLine(customer.Name);
            Console.WriteLine();

            Customer customer2 = new Customer(2, "Ivan");
            Console.WriteLine(customer2.ID);
            Console.WriteLine(customer2.Name);
            Console.WriteLine();
        }
    }
}
