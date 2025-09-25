using System;
using System.Threading;

namespace CountdownProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    Thread.Sleep(500); // 0.5 seconds after 5
                }
                else
                {
                    Thread.Sleep(1000); // 1 second after other numbers
                }
            }

            Console.WriteLine("welcome " + username);
        }
    }
}
