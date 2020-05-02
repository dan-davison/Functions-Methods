using System;

namespace DanDavison_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string:");
            string sentance = Console.ReadLine();

            int count = 0;

            char space = ' ';

            foreach (char c in sentance)
            {
                if( c == space )
                {
                    count++;
                }
            }

            Console.WriteLine("'" + sentance + "'" + " contains " + count + " spaces");
        }
    }
}
