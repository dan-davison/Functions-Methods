using System;

namespace DanDavison_Task3
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Enter a number:");
            var num1 = (Console.ReadLine());
            

            Console.WriteLine("Enter another number:");
            var num2 = (Console.ReadLine());

            int a = int.Parse(num1);
            int b = int.Parse(num2);
            int sum = a + b;

            Console.WriteLine("The sum of two numbers is: " + sum);
        }
    }
}
