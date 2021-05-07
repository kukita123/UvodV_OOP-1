using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._21_UprazhnenieKonstruktori
{
    class CarShowroom
    {
        public Car car;      
        public int count;

        public CarShowroom()
        {
            this.car = new Car();
        }

        public CarShowroom(string brand,string model, int speed, string color, int count)
        {
            this.car = new Car(brand, model, speed, color);
            this.count = count;
        }

        public CarShowroom(Car car, int count)
        {
            this.car = car;
            this.count = count;
        }

        public void DisplayCarsData()
        {
            Console.WriteLine(this.car.DisplayCar());
            Console.WriteLine("Count: " + this.count);
        }

    }
}
