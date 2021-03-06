using System;
using TemplateMethodPattern.Objects;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            University university = new University();
            Сollege college = new Сollege();

            school.Learn();
            university.Learn();
            college.Learn();

            Console.WriteLine();
        }
    }
}
