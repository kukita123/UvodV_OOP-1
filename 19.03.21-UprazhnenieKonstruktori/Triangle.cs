using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Да се състави програма, описваща клас и обекти за триъгълници, която посредством свойства изчислява 
 * лицето по три страни и вида на триъгълника.
 */

namespace _19._03._21_UprazhnenieKonstruktori
{
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        private string color;

        public string Color { get; set; }

        public double A
        {
            get;
            set;
        }

        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public double C { get; set; }

        public Triangle()
        {
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.color = "blue";
        }
        public Triangle(double a, double b, double c)
            :this()
        {
            if (IsTriangleExists(a, b, c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
        public Triangle(double a, double b, double c, string color)
            :this(a, b, c)
        {
            this.color = color;   
        }
        public void PrintTriangleData()
        {
            Console.WriteLine("a = {0}, b = {1}, c = {2}, color: {3}", A, B, C, Color);
        }
        public bool IsTriangleExists(double a, double b, double c)
        {
            bool exixts = (a + b > c) && (a + c > b) && (b + c > a) && (a > 0) && (b > 0) && (c > 0);
            return exixts;
        }
        public double TriangleArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public string TriangleType()
        {
            if (A == B && B == C && A == C)
                return "The triangle is equilateral";
            else if (A != B && B != C && A != C)
                return "The triangle is versatile";
            else
                return "The triangle is isosceles";

        }

    }
}
