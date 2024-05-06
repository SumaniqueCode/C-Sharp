//Usig lambda expression in C-Sharp

using System;

class Program{
    static int test1()=>5;
    static int test2(int x)=>10+x;

    static void Main(string[] args)
    {
        int x= test1();
        int result = test2(x);
        Console.WriteLine("The result is: "+result);
    }
}