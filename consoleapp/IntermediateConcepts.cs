using System;
public class IntermediateConcepts{
    public void Review(int x, int y, int z){
        
        DelegatePrac del = new DelegatePrac();
        del.sumItUp(x, y);

        ThreadPrac.sum(x, y);
        
        Generic generic = new Generic();
        generic.sum(x, y);

        double a = 10; double b = 20;
        generic.sum(a, b);

        Console.WriteLine();
    }
}