using System;

namespace consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# DotnetCore World !!!");
            Console.WriteLine("-----------------------");

            int x = 5; int y = 10; int z = 5;
            
            // BASIC OOPS Concepts
            Console.WriteLine("Basic OOPS Concepts");
            Console.WriteLine("-----------------------");

            OOPSPrac oopsPrac = new OOPSPrac();
            oopsPrac.Review(x, y, z);

            // Intermediate Concepts
            Console.WriteLine("Intermediate C# Concepts");
            Console.WriteLine("-----------------------");

            IntermediateConcepts intermediateConcepts = new IntermediateConcepts();
            intermediateConcepts.Review(x, y, z);
        }
    }
}
