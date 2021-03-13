using System;
using VisitorPattern.Objects;
using VisitorPattern.Serialize;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir873540934", Number = "4573568223" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            Console.ReadLine();
        }
    }
}
