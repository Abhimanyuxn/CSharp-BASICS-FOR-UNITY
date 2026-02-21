using System;
class guess
{
    static void Main(string[]args)
    {
        string word="w";
        String guess="";
        int count =0;
        int limit= 3;
        bool isout=false;


        while(guess != word && !isout)
        {
            if(count<limit)
            {
            Console.Write("Enter a alphabet: ");
            guess= Console.ReadLine();
            count++;
            }
            else
            {
                isout = true;
                
            }
        }
        if(isout)
        Console.Write("YOU LOST ");
        else{
        Console.Write("YOU WON ");
        }
        
    }
}