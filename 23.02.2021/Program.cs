using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Създайте клас Card, който има структура на библиотечен картон. 
// Нека класът да съхранява името, автора и броя на наличните екземпляри от книгата. 
// Съхранете името и автора като низове, а броя като целочислена стойност. 
// Оформете метод Store(), за да запишете данни в картон и  метод Show(), за да покажете информацията. 
// Добавете кратък Мain() метод с обекти за демонстрация на класа.
namespace _23._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Card book1 = new Card();
            Card book2 = new Card();
            Card book3 = new Card();

            book1.Store("Harry Potter", "Joane Rowling", 20);
            book2.Store();

            Console.WriteLine(book1.Show());
            Console.WriteLine(book2.Show());
            Console.WriteLine(book3.Show());

            Console.ReadKey();

        }
    }
}
