using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Book("Demo");

            demo.AddGrade(95);
            demo.AddGrade(50);
            demo.AddGrade(90);
            demo.AddGrade(100);
            demo.AddGrade(83.3);


            Console.WriteLine("Hello World!");
            Console.WriteLine(demo.ToString());
            Console.WriteLine(demo.GetStatistics().ToString());
        }
    }
}
