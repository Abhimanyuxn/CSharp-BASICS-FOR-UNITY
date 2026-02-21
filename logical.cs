using System;
class logic
{
    static void Main(string[]args)
    {
        Console.Write("Enter score of rahul: ");
        int ra = int.Parse(Console.ReadLine());

        Console.Write("Enter score of rohit: ");
        int ro = int.Parse(Console.ReadLine());

        Console.Write("Enter score of virat: ");
        int v = int.Parse(Console.ReadLine());

        if(v>ro && v>ra)
        Console.Write("virat scored more" +v);

        else if (ro>v && ro>ra)
        Console.Write("rohit scored more");

        else
        Console.Write("rahul scored more");


    }
}