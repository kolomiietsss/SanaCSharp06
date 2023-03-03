using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class Student : Enrollee
    {
        public Student(string name, string surname, DateTime birthday, int znoScore, double schoolScore, string school, int course, string group, string faculcy, string university) : base(name, surname, birthday, znoScore, schoolScore, school)
        {
            Course = course;
            Group = group;
            Faculcy = faculcy;
            University = university;
        }

        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculcy { get; set; }
        public string University { get; set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Faculcy: {Faculcy}");
            Console.WriteLine($"University: {University}");
        }
    }
}
