using System;
class Cons
{
    private int sum;

    //Constructor should have same name as class name and are initialized when class instance is called.
    public Cons(int a, int b)
    {
        sum = a + b;
        Console.WriteLine("The sum is: " + sum);
    }
}
class Program
{
    static void Main(string[] args)
    {
        //Calling the instance of class
        new Cons(10, 20);
    }
}