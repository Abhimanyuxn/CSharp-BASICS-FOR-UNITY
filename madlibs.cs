using System;
class program
{
    static void Main (string[]args)
    {
        Console.Write("Name");
     string name=Console.ReadLine();
     Console.Write("age");
     int age = int.Parse(Console.ReadLine());
     Console.WriteLine("My name is " + name);
      Console.WriteLine("My age is "+age);
    }
}