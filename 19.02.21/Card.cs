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
namespace _19._02._21
{
    class Card
    {
        public string bookName;
        public string bookAutor;
        public int count;

        public void Store(string book_name, string book_autor, int book_count)
        {
            bookName = book_name;
            bookAutor = book_autor;
            count = book_count;
        }

        public void Store()
        {
            Console.Write("Enter book name:");
            bookName = Console.ReadLine();
            Console.Write("Enter the name of the autor:");
            bookAutor = Console.ReadLine();
            Console.Write("Enter books count:");
            count = int.Parse(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("Book name: {0}", bookName);
            Console.WriteLine("Autor: {0}", bookAutor);
            Console.WriteLine("Count: {0}", count);
        }
    }
}
