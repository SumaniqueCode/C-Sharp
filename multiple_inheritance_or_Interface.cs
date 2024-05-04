//C# doesnot allow multiple inheritance so in oreder to achieve multiple inheritance we use interface

using System;

//Declaring Interface
interface A
{
    //Interface doesnot contain data members
    //They contain method signature

    int CalculateArea();
    int CalculatePerimeter();
}

class B
{
    public int l, b;
    public void ReadData(int l, int b)
    {
        this.l = l;
        this.b = b;
    }
}

//Class C inheritates multiple classes 
class C : B, A
{
    public int CalculateArea()
    {
        ReadData(4, 5);
        int area = l * b;
        return area;
    }
    public int CalculatePerimeter()
    {
        ReadData(10, 5);
        int perimeter = 2 * (l + b);
        return perimeter;
    }
}

//Main class
class Program
{
    static void Main(string[] args)
    {
        C obj = new C();
        Console.WriteLine("\nThe area of given rectangle is: " + obj.CalculateArea());
        Console.WriteLine("The perimeter of given rectangle is: " + obj.CalculatePerimeter());
    }
}