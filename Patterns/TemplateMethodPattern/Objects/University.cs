using TemplateMethodPattern.Interfaces;
using System;

namespace TemplateMethodPattern.Objects
{
    class University : Education
    {
        public override void Entry() => Console.WriteLine("\nСдаем вступительные экзамены и поступаем в ВУЗ");
        public override void Study() 
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }
        public override void PassExams()  => Console.WriteLine("Сдаем экзамен по специальности");
        public override void GetDocument() => Console.WriteLine("Идем в первый класс");
    }
}
