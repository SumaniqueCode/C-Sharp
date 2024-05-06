//Example of deligate for adding two numbers
//It is also example of multicast deligate

using System;

class DelegateTest
{
    public delegate int DeligateNum(int x, int y);

    public static int AddNum(int x, int y)
    {
        int result = x + y;
        return result;
    }

    public static int MulNum(int x, int y)
    {
        int result = x * y;
        return result;
    }

    static void Main(string[] args)
    {
        DeligateNum sum = AddNum;
        Console.WriteLine(sum(5, 2));
        DeligateNum mul = MulNum;
        Console.WriteLine(mul(10, 12));


    }
}

