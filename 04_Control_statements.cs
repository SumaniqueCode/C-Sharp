//The control statement include conditional statement, looping statemnts, Jump statements, etc
//Among them we will use conditional and looping statements hereusing System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nDemonstration of if statement");
        Console.WriteLine("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age < 18)
            Console.WriteLine("You are a minor");
        else
            Console.WriteLine("You are not a minor");

        //if-else-if statement
        Console.WriteLine("\nDemonstration of if-else if-else statement");
        Console.WriteLine("Enter your Marks : ");
        int marks = Convert.ToInt32(Console.ReadLine());
        if (marks >= 80)
            Console.WriteLine("Grade A+");
        else if (marks >= 70)
            Console.WriteLine("Grade A");
        else if (marks >= 60)
            Console.WriteLine("Grade B");
        else
            Console.WriteLine("Fail");

        //Looping statements
        //To print from 1 to 5 using for loop
        Console.WriteLine("\nDemonstration of for loop");
        for (int i = 1; i <= 5; i++)
            Console.Write(i + " ");

        Console.WriteLine("\nDemonstration of do while loop");
        int count = 1;
        do
        {
            Console.Write(count + " ");
            count++;
        } while (count <= 5);
    }
}