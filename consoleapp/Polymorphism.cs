using System;

public class Polymorphism{
    public int sum (int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (Polymorphism - two params) for {0}, {1} is {2} ", x, y, sum);
        return sum;
    }

    public int sum (int x, int y, int z){
        int sum = x+y+z;
        Console.WriteLine("Sum (Polymorphism - three params) for {0}, {1}, {2} is {3} ", x, y, z, sum);
        return sum;
    }
}