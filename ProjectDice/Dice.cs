using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDice
{
    public class Dice
    {
        public string Type;
        public int Sides;

        public void SetFields()
        {
            Console.Write("Enter dice type: ");
            Type = Console.ReadLine();

            Type = Type.ToLower();

            switch(Type)
            {
                case "tetrahedron":
                    Sides = 4;
                    break;
                case "cube":
                    Sides = 6;
                    break;
                case "octahedron":
                    Sides = 8;
                    break;
                case "dodecahedron":
                    Sides = 12;
                    break;
                case "icosahedron":
                    Sides = 20;
                    break;
                default:
                    Sides = 0;
                    break;
            }
        }
        public void SetFields(string type, int sides)
        {
            Type = type;
            Sides = sides;
        }
        public int Roll()
        {
            Random random = new Random();
            int roll;

            switch (Sides)
            {
                case 4: 
                    roll = random.Next(1, 4); 
                    break;
                case 6: 
                    roll = random.Next(1, 6); 
                    break;
                case 8: 
                    roll = random.Next(1, 8); 
                    break;
                case 12: 
                    roll = random.Next(1, 12); 
                    break;
                case 20: 
                    roll = random.Next(1, 20);
                    break;
                
                default: 
                    roll = 0; 
                    break;
            }

            return roll;
        }
        public void Display()
        {
            Console.WriteLine("Rolling the {0} ......", Type);

            if(Sides > 0)
                Console.WriteLine("The result is {0}", this.Roll());
            else
                Console.WriteLine("Incorrect dice, sides must be bigger than 0");

            Console.WriteLine();
        }
    }
}
