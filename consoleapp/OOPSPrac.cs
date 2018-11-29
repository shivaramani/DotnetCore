using System;
public class OOPSPrac{
    public void Review(int x, int y, int z){
        
        SimpleClass simpleClass = new SimpleClass();
        simpleClass.sum(x, y);

        Numberclass numclass = new Numberclass();
        numclass.sum(x, y);

        AbstractClassPrac implClass = new ImplementingClass();
        implClass.sum(x, y);

        SealedClass sealedClass = new SealedClass();
        sealedClass.sum(x, y);

        Console.WriteLine();

        Encapsulation encapsulation = new Encapsulation();
        encapsulation.sum(x, y);

        Polymorphism polymorphism = new Polymorphism();
        polymorphism.sum(x,y);
        polymorphism.sum(x,y,z);

        Console.WriteLine();
        
        
    }
}