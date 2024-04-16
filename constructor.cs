using System;
class Cons{
    private int sum;
    public Cons(int a, int b){
        sum= a+b;
        Console.WriteLine("The sum is: "+ sum);
    }
}
class Program{
    static void Main(string[] args)
    {
        new Cons(10,20);
    }
}