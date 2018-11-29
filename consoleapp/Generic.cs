using System;
using System.Collections.Generic;

public class Generic{
    
    public T sum<T> (T x, T y){
        dynamic num1 = x;
        dynamic num2 = y;
        dynamic sum = num1 + num2;
        Console.WriteLine("Sum (Generic) for {0}, {1} is {2}  ", num1, num2, sum);
        return sum;
    }
}
