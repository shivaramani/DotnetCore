using System;

public class SimpleClass{
    public int sum (int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (SimpleClass) for {0}, {1} is {2} ", x, y, sum);
        return sum;
    }
}