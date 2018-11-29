using System;

public interface IAdd{
    int sum (int x, int y);
}

public class Numberclass: IAdd{
    public int sum (int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (Interface) for {0}, {1} is {2} ", x, y, sum);
        return sum;
    }
}