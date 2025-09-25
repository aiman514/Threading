
using System;
using System.Threading;
class Program
{
    static void Main()
    {
        //Pac-Man eats the dot -> blink effect
        string line = "------------";//dots Pac-Man will eat
        int length = line.Length;
        for (int i = 0; i < length; i++)
        {
            Console.Write("\r" + new string(' ', i) + "C" + line.Substring(i + 1));
            Thread.Sleep(200);//Pac-Man arrives
            Console.Write("\r" + new string(' ', i + 1) + line.Substring(i + 1));
            Thread.Sleep(200);// dots disappears (blink)
        }
        Console.Write("\r" + new string(' ', length) + "C");
        Console.WriteLine("\n\nGame Over! Pac-Man ate all the dots!");
    }
}
