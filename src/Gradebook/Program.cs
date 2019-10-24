using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Default";

            if (args.Length > 0) {
                name = args[0];
            }

            Console.WriteLine($"Hello {name}!");
        }
    }
}
