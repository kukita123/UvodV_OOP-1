using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._03._21
{
    class RacionalNumber
    {
        public int numerator;
        public int denominator;

        public RacionalNumber()
        {
            this.denominator = 1;
        }

        public RacionalNumber(int Numerator, int Denominator)
        {
            this.numerator = Numerator;
            if (Denominator != 0)
                this.denominator = Denominator;
            else
                this.denominator = 1;
        }

        public void PrintRationalNumber()
        {
            Console.WriteLine(this.numerator+"/"+this.denominator);
        }
        
        public void Reduction()
        {
            if (this.numerator >= this.denominator)
                Console.WriteLine(this.numerator / this.denominator + " " + this.numerator % this.denominator + "/" + this.denominator);
            else
                PrintRationalNumber();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RacionalNumber r1 = new RacionalNumber();
            r1.PrintRationalNumber();

            RacionalNumber r2 = new RacionalNumber(3, 7);
            r2.PrintRationalNumber();

            RacionalNumber r3 = new RacionalNumber(9,2);
            r3.PrintRationalNumber();
            r3.Reduction();

            Console.ReadKey();
        }
    }
}
