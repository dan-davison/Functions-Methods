using System;

namespace DanDavison_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a name:");
            string Firstname = Console.ReadLine();

            string message = "Welcome friend " + Firstname;

            Console.WriteLine(message);
            Console.WriteLine("Have a nice day!");
        }
    }
}
