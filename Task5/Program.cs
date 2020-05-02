using System;

namespace DanDavison_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] element  = new int[5];

            element  [0] = 5;
            element  [1] = 7;
            element  [2] = 3;
            element  [3] = 2;
            element  [4] = 9;

            int sum = 0;

            for (int i =0; i <element .Length; i++){
                sum +=element [i];
            }

            System.Console.WriteLine("The sum of the elements of the array is " + sum);
        }
    }
}
