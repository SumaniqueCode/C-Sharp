using System;
class Cons
{
    private int sum;
    public Cons(int a, int b)
    {
        sum = a + b;
        Console.WriteLine("The sum is: " + sum);
    }
    public Cons(int a, int b, int c)
    {
        sum = a + b + c;
        Console.WriteLine("The sum is: " + sum);
    }
    public void Add(int a, int b)
    {
        sum = a + b;
        Console.WriteLine("The sum is: " + sum);
    }
    public void Add(int a, int b, int c)
    {
        sum = a + b + c;
        Console.WriteLine("The sum is: " + sum);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Cons
        Cons sum = new Cons(10, 20);

        // Call constructor and methods
        new Cons(10, 20, 30);
        sum.Add(10, 20);
        sum.Add(10, 20, 30);
    }
}