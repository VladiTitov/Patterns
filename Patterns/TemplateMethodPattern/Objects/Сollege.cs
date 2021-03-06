using TemplateMethodPattern.Interfaces;
using System;

namespace TemplateMethodPattern.Objects
{
    class Сollege : Education
    {
        public new void Learn() => Console.WriteLine("\nНе хочу учиться!");

        public override void Entry() { }

        public override void GetDocument() { }

        public override void Study() { }
    }
}
