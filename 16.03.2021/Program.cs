using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //RacionalNumber r1 = new RacionalNumber();
            //r1.Print();
            //RacionalNumber r2 = new RacionalNumber(3, 0);
            //r2.Print();
            //RacionalNumber r3 = new RacionalNumber(3, 4);
            //r3.Print();

            Person p1 = new Person();
            p1.Print();

            DateTime date1 = new DateTime(2005, 4, 23);

            Person p2 = new Person(3, date1);
            p2.FirstName = "Petko";
            p2.LastName = "Petkov";
            p2.Print();

            Console.ReadKey();
        }
    }
}
