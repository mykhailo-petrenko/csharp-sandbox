using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book("John");
            var b2 = new Book("Dolly");

            b1.AddGrade(12.0);
            b1.AddGrade(11.1);
            b1.AddGrade(10.2);

            b2.AddGrade(11.2);
            b2.AddGrade(13.3);
            b2.AddGrade(13.1);

            Console.WriteLine("Hello World!");
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b2.ToString());
        }
    }
}
