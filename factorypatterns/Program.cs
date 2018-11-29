using System;

namespace factorypatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns!");
            Console.WriteLine();

            FactoryCaller factorypattern = new FactoryCaller();
            factorypattern.InvokePattern();

            Singletoncaller singletonPattern = new Singletoncaller();
            singletonPattern.InvokePattern();
        }
    }
}
