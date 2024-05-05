//Sum of n numbers using array
using System;

class Program
{
    static void Main(string[] args)
    {

        int n;
        double sum = 0;
        Console.WriteLine("\nHow many numbers do you want to add?");
        n = Convert.ToInt32(Console.ReadLine());
        double[] num = new double[n];
        Console.WriteLine("Enter numbers.");
        for (int i = 0; i < n; i++)
        {
            num[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            sum = sum + num[i];
        }
        Console.WriteLine("The sum of given numbers is: " + sum);
    }
}
