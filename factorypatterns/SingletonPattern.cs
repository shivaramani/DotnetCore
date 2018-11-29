using System;

/*

    Note : 
    Only a single instance (the singleton) of the class can be created
    To create the static "Instance" the class CANNOT be static
    Optionally have a "lock" before creating the instance

 */

public class Singleton{
    private static Singleton _instance;
    private static object syncLock = new object();
    public static Singleton Instance(){

        lock (syncLock)
        {
            if(_instance == null){
                _instance = new Singleton();
                Console.WriteLine("Singleton Instance called firstime ONLY");    
            }
        }

        Console.WriteLine("Singleton Instance called everytime");
        return _instance;
    }
}

public class Singletoncaller{
    public void InvokePattern(){
        Console.WriteLine("Invoking Singleton Pattern - ");

        Singleton s1 = Singleton.Instance();
        Singleton ss = Singleton.Instance();

        Console.WriteLine();
    }
}