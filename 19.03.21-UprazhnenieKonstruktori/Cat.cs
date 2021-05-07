using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._21_UprazhnenieKonstruktori
{
    class Cat
    {
        public string name;
        public string color;
        public int age;

        public Cat()
        {
            this.name = "Maca";
            this.color = "white";
        }
        public Cat(string Name, string Color)
        {
            this.name = Name;
            this.color = Color;
        }
        public Cat(string Name, string Color, int Age)
            :this(Name,Color)
        {
            this.age = Age;
        }
        public void PrintData()
        {
            Console.WriteLine("Cat's name: {0}",this.name);
            Console.WriteLine("Cat's color: {0}", this.color);
            Console.WriteLine("Cat's age: {0}", this.age);
        }
        public void Meow()
        {
            Console.WriteLine("The cat {0} says Meow!!!", this.name);
        }
        public void Mrrrrrr()
        {
            Console.WriteLine("The cat {0} says Mrrrrrr!!!", this.name);
        }
    }
}
