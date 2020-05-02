using System;

namespace DanDavison_Task7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input Base number: ");
            var num1 = (Console.ReadLine());

            Console.WriteLine("Input the Exponent: ");
            var num2 = (Console.ReadLine());

            int baseNumber =  int.Parse(num1);
            int exponent = int.Parse(num2);

            double power = Math.Pow(baseNumber, exponent);

            System.Console.WriteLine("So, the number " + baseNumber + " ^ " + exponent + " = " + power);

        }
    }
}
