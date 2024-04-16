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
            foreach (int e in array)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine("");
        }
    }
}