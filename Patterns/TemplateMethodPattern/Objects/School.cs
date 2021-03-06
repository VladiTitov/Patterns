using TemplateMethodPattern.Interfaces;
using System;

namespace TemplateMethodPattern.Objects
{
    class School : Education
    {
        public override void Entry() => Console.WriteLine("\nИдем в первый класс");
       
        public override void GetDocument() => Console.WriteLine("Посещаем уроки, делаем домашние задания");

        public override void Study() => Console.WriteLine("Получаем аттестат о среднем образовании");
    }
}
