using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*


 */
namespace _19._03._21_UprazhnenieKonstruktori
{

    class Program
    {
        static void Main(string[] args)
        {
            #region
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle(2, 2, 3);
            Triangle t3 = new Triangle(2, 3, 55);
           

            t1.A = 5;
            t1.C = 6;
            t1.Color = "white";

            t2.A = 2;
            t2.B = 2;
            t2.C = 3;
            t2.Color = "blue";

            t3.A = 5;
            t3.B = 5;
            t3.C = 5;
            t3.Color = "green";
                       
            t1.PrintTriangleData();
            t2.PrintTriangleData();
            t3.PrintTriangleData();  

            Console.WriteLine("Area = {0:f2}", t1.TriangleArea());
            Console.WriteLine("Area = {0:f2}", t2.TriangleArea());
            Console.WriteLine("Area = {0:f2}", t3.TriangleArea());

            Console.WriteLine(t1.TriangleType());
            Console.WriteLine(t2.TriangleType());
            Console.WriteLine(t3.TriangleType());

            //Cat kitty1 = new Cat();
            //Cat kotarana = new Cat("Pisana", "Yellow", 2);
            //Cat kitty2 = new Cat("Garfield", "Orange");
            //Cat pissi = new Cat { name = "Pissi", color = "grey", age = 1 };

            //kitty1.Meow();
            //kitty2.Mrrrrrr();
            //kotarana.PrintData();
            //Console.WriteLine(kitty1.name);
            //kitty1.name = "Pesho";
            //Console.WriteLine(kitty1.name);
            //pissi.PrintData();
            //// and applying other methods .....
            #endregion

            //Car car1 = new Car();
            //Console.WriteLine(car1.DisplayCar());

            //Car car2 = new Car("Renault", "Captur", 180, "red");
            //Console.WriteLine(car2.DisplayCar());
            //Console.WriteLine();

            //CarShowroom showRoom1 = new CarShowroom();
            //showRoom1.DisplayCarsData();
            //Console.WriteLine();

            //CarShowroom showRoom2 = new CarShowroom(car2, 5);
            //showRoom2.DisplayCarsData();
            //Console.WriteLine();

            //CarShowroom showRoom3 = new CarShowroom("Ford", "Focus", 200, "black", 3);
            //showRoom3.DisplayCarsData();
            //Console.WriteLine();

            //CarShowroom showroom4 = new CarShowroom(new Car { brand = "BMW", model = "X1", color = "white", speed = 240 }, 2);
            //showroom4.DisplayCarsData();
            //Console.WriteLine();

            Console.ReadKey();
        }
    }
}
