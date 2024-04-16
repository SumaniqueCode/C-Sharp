using System;
namespace arraySum
{
    class arraySum
    {
        public static void Main(string[] args)
        {
            int[] a = new int[100];
            int n, i, sum = 0;
            Console.Write("Enter the total no. of elements: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements");
            for (i = 0; i < n; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            // Calculate Sum of Array Elements
            for (i = 0; i < n; i++)
                sum += a[i];

            Console.WriteLine("The sum of the given array is: " + sum);
        }
    }
}