using System;

namespace TemplateMethodPattern.Interfaces
{
    abstract class Education
    {
        public void Learn()
        {
            Entry();
            Study();
            PassExams();
            GetDocument();
        }

        public abstract void Entry();
        public abstract void Study();
        public virtual void PassExams() => Console.WriteLine("Сдаем выпускные экзамены");
        public abstract void GetDocument();
    }
}
