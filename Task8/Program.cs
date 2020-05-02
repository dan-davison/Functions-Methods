using System;

namespace DanDavison_Task8
{
    class Program
    {
        public static void Main(string[] args)
        { 

            int num1 = 0, num2 = 1, num3, i; 

            Console.WriteLine("Input number of Fibonacci Series :");
            var input = (Console.ReadLine());

            int value =  int.Parse(input);

            if (value==1)
            {
                Console.WriteLine("The Fibonacci series of " + value + " number is : "); 
                Console.Write(num1);
            }

            else if (value == 2)
            {
                Console.WriteLine("The Fibonacci series of " + value + " numbers is : "); 
                Console.Write(num1 + ", " + num2); 
            }

            else if (value>=3)
            {   
                Console.WriteLine("The Fibonacci series of " + value + " numbers is : "); 
                Console.Write(num1 + ", " + num2 + ", "); 

                for( i = 2 ; i <value ; ++i)
                {   
                    num3 = num1 + num2; 
                    Console.Write(num3+", ");   
                    num1 = num2;  
                    num2 = num3; 
                }  
            }

        } 
    }
}