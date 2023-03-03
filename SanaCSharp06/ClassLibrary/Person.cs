using System.Xml.Linq;
using System;

namespace ClassLibrary
{
    public class Person
    {
        public Person(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            Birthday = birthDate;
        }
        public Person() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Birthday: {Birthday.Year}.{Birthday.Month}.{Birthday.Day}.");
        }


    }
}