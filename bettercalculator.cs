using System;
class betterCalculator
{
    static void Main(string[]args)
    {
        Console.Write("Enter first number: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter operator: ");
        string op = Console.ReadLine();

        Console.Write("Enter second number: ");
        int y = int.Parse(Console.ReadLine());

        if(op == "+")
        {
           int sum=x+y;
            Console.Write("Sum is " +sum);
        }
        else if ( op == "-")
        {
            int diff=x-y;
            Console.Write("Difference is " +diff);
        }
        else if ( op == "*")
        {
            int mult=x*y;
            Console.Write("Product is " +mult);
        }
         else if ( op == "/")
        {
            int div=x/y;
            Console.Write("Division is " +div);
        }
        else 
        Console.Write("Invalid Operator");



    }
}