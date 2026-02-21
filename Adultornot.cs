using System;
class Adult
{
    static void Main(string[]args)
    {
        Console.Write("what is your age ? : ");
        int age = int.Parse(Console.ReadLine());
        int sample=18;

        if(age>=sample)
        {
           Console.Write("Adult");
            }
            else
            Console.Write("Not Adult");
    }
}