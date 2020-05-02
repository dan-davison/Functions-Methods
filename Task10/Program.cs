using System;

namespace DanDavison_Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sum =0;
            int i =0;

            Console.WriteLine("Enter a number: ");

            var input = (Console.ReadLine());
            int num =  int.Parse(input);
            
            while (num !=0)
            {
                i = num % 10;
                num = num / 10;
                sum = sum + i;
            }

            Console.Write("The sum of the digits of the number " + input + " is " + sum);



        }
    }
}
