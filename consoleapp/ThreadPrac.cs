using System;
using System.Threading;

public static class ThreadPrac{
    private static int add (int x, int y, bool isThread){
        int sum = x+y;
        Console.WriteLine("Sum (Thread Class: IsThreaded - {3}) for {0}, {1} is {2} ", x, y, sum, isThread);
        return sum;
    }

    public static void HelloThread(){
        // Do nothing
        //Console.WriteLine("************");
    }

    public static int sum(int x, int y){
        Thread thread = new Thread(new ThreadStart(HelloThread));
        thread.Name = "MyThread";
        int intThreadHashCode = thread.GetHashCode();
        thread.Start();
        //Console.WriteLine("Name & Hashcode of Thread  : {0},{1}", thread.Name, intThreadHashCode);
        // Thread.Sleep(3000);

        Thread t2 = new Thread(new ThreadStart(
            delegate{
                add(x, y, true);
            }
        ));

        t2.Name = "Parameterized Thread";
        int intT2HashCode = t2.GetHashCode();
        t2.Start();
        //Console.WriteLine("Name & Hashcode of Parameterized Thread  : {0},{1}", t2.Name, intT2HashCode);

    
        return add(x, y, false);
    }
}