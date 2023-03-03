using System;
using ClassLibrary;

namespace SanaCSharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            persons.Add(new Person("Person1", "Person1", new DateTime(2000, 1, 1)));
            persons.Add(new Enrollee("Enrollee1", "Enrollee1", new DateTime(2001, 2, 2), 450, 10.0, "Ліцей при ЖДТУ"));
            persons.Add(new Student("Student1", "Student1", new DateTime(1988, 8, 7), 450, 10.0, "Ліцей при ЖДТУ",3, "IPZ-22-1", "FICT", "ZSTU"));
            persons.Add(new Teacher("Teacher1", "Teacher2", new DateTime(1968, 8, 7), "Teacher", "IPZ", "ZSTU"));
            persons.Add(new LibraryUser("LibraryUser1", "LibraryUser1", new DateTime(1968, 8, 7), 1, new DateTime(2023, 1, 12), 50.5));
            foreach (var p in persons)
            {
                p.ShowInfo();
                Console.WriteLine();
            }

        }
    }
}