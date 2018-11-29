using System;

public sealed class SealedClass{

    public const string Message  = "Sealed class message";
    public int sum(int x, int y){
        int sum = x+y;
        Console.WriteLine("Sum (SealedClass) for {0}, {1} is {2} ", x, y, sum);
        return sum;
    }

    // This is not possible. we cannot make the sealed class abstract
    // public abstract int add(int x, int y);
}

// Sealed CANNOT be derived - below not possible
// public class Implementationclass: SealedClass{
public class Implementationclass{
    
    public int sum(int x, int y){
        Console.WriteLine(SealedClass.Message);
        
        SealedClass sealedClass = new SealedClass();
        return sealedClass.sum(x, y);
    }
    
}