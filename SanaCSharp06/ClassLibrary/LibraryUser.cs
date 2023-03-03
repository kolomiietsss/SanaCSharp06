using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Сontributions { get; set; }

        public LibraryUser() { }

        public LibraryUser(string name, string surname, DateTime birthDate, int id, DateTime registrationDate, double payment) : base(name, surname, birthDate)
        {
            Id = id;
            RegistrationDate = registrationDate;
            Сontributions = payment;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"RegistrationDate: {RegistrationDate.Year}.{RegistrationDate.Month}.{RegistrationDate.Day}.");
            Console.WriteLine($"Сontributions: {Сontributions}");
        }
    }
}
