// Created On 2024/03/12
// By Suman Regmi

using System;
class Program
{
    public static void Main(string[] args)
    {
        int a, b, sum;
        Console.Write("Enter the first number: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        b = Convert.ToInt32(Console.ReadLine());
        sum = a+b;
        Console.WriteLine("The sum is {0}",sum);
    }
}