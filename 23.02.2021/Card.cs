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
    class Card
    {
        public string bookName;
        public string bookAutor;
        public int count;

        public void Store(string bookname, string bookautor, int bookcount)
        {
            bookName = bookname;
            bookAutor = bookautor;
            count = bookcount;
        }

        public void Store()
        {
            Console.WriteLine("Enter book name: ");
            bookName = Console.ReadLine();
            Console.WriteLine("Enter book autor: ");
            bookAutor = Console.ReadLine();
            Console.WriteLine("Enter books count: ");
            count = int.Parse(Console.ReadLine());
        }

        public string Show()
        {
            string result = bookName + ", autor: " + bookAutor + ", - " + count + " counts";
            return result;
        }
    }
}
