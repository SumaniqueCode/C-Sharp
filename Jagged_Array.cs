using System;
class Jagged
{
    static void Main(String[] args)
    {
        int[][] jagged = new int[][]
        {
            new int[] { 1, 2 },
            new int[] { 2, 3, 4 },
            new int[] { 3, 4, 5, 6 }
        };

        foreach (int[] array in jagged)
        {
            int sum = 0;
            foreach (int e in array)
            {
                Console.Write(e + " ");
                sum = sum +e;
            }
            Console.Write("The sum of this row is: "+ sum);
            Console.WriteLine("");
        }
    }
}