using System;

public abstract class AbstractClassPrac
{
    public abstract int sum(int x, int y);
}

public class ImplementingClass: AbstractClassPrac{
    public override int sum(int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (AbstractClass) for {0}, {1} is {2} ", x, y, sum);
        return x + y;
    }
}
