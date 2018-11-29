using System;

public class Encapsulation{
    private int _x;
    private int _y;

    public int getX(){
        return _x;
    }

    public void setX(int x){
        this._x = x;
    }

    public int getY(){
        return _y;
    }

    public void setY(int y)
    {
        _y = y;
    }

    public int sum (int x, int y){

        // Access/Encapsulate the objects only through propertites
        setX(x);
        setY(y);
        int sum = getX() + getY();
        Console.WriteLine("Sum (Encapsulation) for {0}, {1} is {2} ", getX(), getY(), sum);
        return sum;
    }
}