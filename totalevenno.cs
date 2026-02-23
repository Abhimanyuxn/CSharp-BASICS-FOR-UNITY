using System;
class Even
{
    static void Main(string[]args)
    {
        int i,n=0;
        for(i=1;i<=20;i++)
        {
        if(i%2==0)
        {
           Console.WriteLine(i) ;
           n++;
          }
        }
        Console.WriteLine("Total even numbers are" + n);
    }
}