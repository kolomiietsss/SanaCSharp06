using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Enrollee : Person
    {
        public Enrollee()
        {
        }

        public Enrollee(string name, string surname, DateTime birthDate, int znoScore, double schoolScore, string school) : base(name, surname, birthDate)
        {
            ZNOScore = znoScore;
            SchoolScore = schoolScore;
            School = school;
        }

        public int ZNOScore { get; set; }
        public double SchoolScore { get; set; }
        public string School { get; set; }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ZNO: {ZNOScore} ");
            Console.WriteLine($"SchoolScore: {SchoolScore}");
            Console.WriteLine($"School: {School}");
        }
    }
}
