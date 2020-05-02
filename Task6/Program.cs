using System;

namespace DanDavison_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int tempNumber;

            Console.Write("Enter a number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            number2 = int.Parse(Console.ReadLine());

            tempNumber = number1;

            number1 = number2;

            number2 = tempNumber;

            Console.Write("Now the 1st number is : " + number1 + " , and the 2nd number is : " + number2);

        }
    }
}
