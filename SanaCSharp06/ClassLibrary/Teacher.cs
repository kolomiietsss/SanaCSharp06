using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        public Teacher(string name, string surname, DateTime birthDate, string post, string department, string university) : base(name, surname, birthDate)
        {
            Post = post;
            Department = department;
            University = university;
        }
        public Teacher() { }
        public string Post { get; set; }
        public string Department { get; set; }
        public string University { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Post: {Post}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"University: {University}");
        }
    }
}
