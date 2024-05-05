using System;

class Complex
{
    private int x;
    private int y;

    //No argument constructor
    public Complex() {}
    public Complex(int i, int j)
    {
        x = i;
        y = j;
    }

    //method to display value
    public void Show()
    {
        Console.WriteLine("{0} {1}", x, y);
    }

    //Operator overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        Complex temp = new Complex();
        temp.x = c1.x + c2.x;
        temp.y = c1.y + c2.y;
        return temp;
    }
}
//Main class
class Program
{
    public static void Main(string[] args)
    {
        Complex c1 = new Complex(10, 20);
        c1.Show();
        Complex c2 = new Complex(20, 30);
        c2.Show();
        Complex c3 = c1 + c2;
        c3.Show();
    }
}