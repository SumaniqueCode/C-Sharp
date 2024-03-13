// Created On 2024/03/12
// By Suman Regmi

using System;
class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.Write("Enter the number: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num==0)
            Console.WriteLine("We are still researching whether 0 is odd or even.");
        else if(num%2==0)
            Console.Write("{0} is Even",num);
        else
            Console.Write("{0} is Odd", num);

        if (num>0)
            Console.Write(" and positive number");
        else if(num<0)  
            Console.Write(" and negative number");

    }
}