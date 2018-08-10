using System;

namespace DotnetCorePractice
{
    class Program
    {
            static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello from main!");
            }

            Console.WriteLine("*************");
            Console.WriteLine("Fibinocci from FibinocciGenerator");
            
            var generator = new FibonacciGenerator();
            foreach (var digit in generator.Generate(10))
            {
                Console.WriteLine(digit);
            }
        }

    }

}
