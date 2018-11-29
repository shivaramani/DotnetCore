using System;

public delegate int AddDel (int x, int y);
public class DelegatePrac{
    public int sum(int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (Delegate) for {0}, {1} is {2} ", x, y, sum);
        return sum;
    }

    public int sumItUp(int x, int y){
        AddDel add = sum;
        return sum(x,y);
    }
}