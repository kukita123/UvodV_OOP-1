using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._03._2021
{
    class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BurthDate;

        public Person()
        {
            this.BurthDate = new DateTime();
        }

        public Person(int id)
            :this()
        {
            this.Id = id;
        }           

        public Person(int id, string firstName)
            :this(id)
        { 
            this.FirstName = firstName;
        }

        public Person(int id, string firstName, string lastName)
            :this(id, firstName)
        {
            this.LastName = lastName;
        }

        public Person(int id, DateTime birthDate)
            : this(id)
        {
            this.BurthDate = birthDate;
        }

        public void Print()
        {
            Console.WriteLine($"Id: {this.Id}, {this.FirstName} {this.LastName} - birthdate: {this.BurthDate.ToString()}");
        }

    }

}
