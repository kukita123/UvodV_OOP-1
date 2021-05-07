using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2021
{
    class RacionalNumber
    {
        public int numerator;
        public int denominator;

        public RacionalNumber()
        {
            this.denominator = 1;
        }

        public RacionalNumber(int num, int denum)
        {
            this.numerator = num;

            if (denum != 0)
                this.denominator = denum;
            else
                this.denominator = 1;
        }

        public void Print()
        {
            Console.WriteLine(this.numerator+"/"+this.denominator);
        }
    }
}
