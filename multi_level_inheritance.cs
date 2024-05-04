using System;

//Parent class
class A
{
    public int a, b, c;

    public void ReadData(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void Display()
    {
        Console.WriteLine("The value of a is: " + a);
        Console.WriteLine("The value of b is: " + b);
    }
}

//Inherits class A
class B : A
{
    public void Add()
    {
        base.c = base.a + base.b;
        Console.WriteLine("The sum of {1} and {2} is {0}", base.c, base.a, base.b);
    }
}

//Inherits class B to use the data of class A
class C : B
{

    public void Sub()
    {
        base.c = base.a - base.b;
        Console.WriteLine("The difference of {0} and {1} is {2}", base.a, base.b, base.c);
    }
}

//Main class starts

class Program
{
    static void Main(string[] args)
    {
        C obj = new C();
        obj.ReadData(20, 5);
        obj.Display();
        obj.Add();
        obj.Sub();
    }
}