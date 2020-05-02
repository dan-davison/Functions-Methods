using System;

namespace DanDavison_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter=0;
            int i = 0;

            Console.WriteLine("Input a number :");
            var input = (Console.ReadLine());
            int number =  int.Parse(input);

            for(i = 2 ; i <= number / 2 ; i++)
            {
                if(number % i == 0)
                {
                    counter++;
                    break;
                }
            }

            if(counter==0 && number!= 1)
            {   
                Console.WriteLine(number + " is a prime number");
            }
            
            else
            {
                Console.WriteLine(number + " is not a prime number");
            }

        }
    }
}
