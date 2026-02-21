using System;
 class program
{
    static void Main (string[] args)
    {
        Console.Write("no 1 is ");
        int a=int.Parse(Console.ReadLine());
        Console.Write("no 2 is ");
        int b=int.Parse(Console.ReadLine());
        int sum=a+b;
        int diff=a-b;
        int div=a/b;
        int mult=a*b;
        Console.WriteLine("Sum is" + sum);
        Console.WriteLine("diff is" + diff);
        Console.WriteLine("div is" + div);
        Console.WriteLine("mult is" + mult);


    }
}