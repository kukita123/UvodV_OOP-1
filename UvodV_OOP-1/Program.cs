using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UvodV_OOP_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person();
            var woman = new Person();
            Person child = new Person();
            Person granfather = new Person();

            
            man.name = "Ivan";
            woman.name = "Mariana";

            child.name = "Pepo";
            child.IntroduceTo("Zdrawko");

            System.Console.WriteLine(granfather.name);
            

            woman.IntroduceTo("Petyr");
            woman.IntroduceTo(man.name);

            man.IntroduceTo(woman.name);
            
            System.Console.ReadKey();
        }
    }


}
//Създайте клас Card, който има структура на библиотечен картон. 
//Нека класът да съхранява името, автора и броя на наличните екземпляри от книгата. 
//Съхранете името и автора като низове, а броя като целочислена стойност. 
//Оформете метод Store(), за да запишете данни в картон и  метод Show,за да покажете информацията. 
//Добавете кратка Мain() функция за демонстрация на класа.