using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
а) Да се реализира клас Car, предсталвяващ превозно средство, което се характеризира със 
   заглавие - низ с произволна дължина, модел - низ с произволна дължина, максимална скорост - положително цяло число 
   и цвят - низ с произволна дължина.

б) За класа Car да се дефинират конструктори

в) За класа Car да се дефинира метод за извеждане на конзола

г) Да се реализира клас CarShowroom, който включва различни обекти от клас Car 
   и техния брой - положително цяло число

д) Да се разработят подходящи методи за извеждане на конзола.

е) Да се създадат обекти от класовете и да се тестват методите за извеждане на конзола.
 */

namespace _19._03._21_UprazhnenieKonstruktori
{
    class Car
    {
        public string brand;                    
        public string model;
        public int speed;
        public string color;

        public Car()
        {
            this.brand = "";
            this.model = "";
            this.color = "";
        }

        public Car(string brand, string model, int speed, string color)
        {
            this.brand = brand;
            this.model = model;
            this.speed = speed;
            this.color = color;
        }

        public string DisplayCar()
        {
            return $"{this.brand} - {this.model}, max speed: {this.speed}, color: {this.color}";
        }
    }
}
