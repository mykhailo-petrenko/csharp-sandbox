using System;

namespace GradeBook
{
    class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            GradeAddedDelegate logger = (object sender, EventArgs eventArguments) => {
                Console.WriteLine($"GradeAdded: {sender.ToString()}");
            };

            var demo = new Book("Demo");
            demo.GradeAdded += logger;
            demo.GradeAdded += GradesCounter;

            demo.AddGrade(95);
            demo.AddGrade(50);
            demo.AddGrade(90);
            demo.AddGrade(100);
            demo.AddGrade(83.3);


            Console.WriteLine($"Grades Added: {counter}.");
            Console.WriteLine(demo.ToString());
            Console.WriteLine(demo.GetStatistics().ToString());
        }

        static void GradesCounter(object sender, EventArgs args)
        {
            counter += 1;
        }
    }
}
