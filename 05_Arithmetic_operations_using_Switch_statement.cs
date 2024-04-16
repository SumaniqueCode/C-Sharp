//To perform arithmetic operation using switch operations

using System;
using System.Diagnostics;

Console.WriteLine("*******Arithmetic Operation using switch statement******");
Console.WriteLine("\nEnter any two numbers");
double num1 = Convert.ToDouble(Console.ReadLine());
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the operation +, -, *, /");
string operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine("The sum is " + (num1 + num2));
        break;
    case "-":
        Console.WriteLine("The difference is " + (num1 - num2));
        break;

    case "*":
        Console.WriteLine("The product is " + (num1 * num2));
        break;
    case "/":
        Console.WriteLine("The result is " + (num1 / num2));
        break;
    default:
        Console.Write("Invalid Operator");
        break;

}
