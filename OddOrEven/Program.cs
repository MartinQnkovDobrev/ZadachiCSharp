using System;
//Problem 1. Odd or Even Integers
//    Write an expression that checks if given integer is odd or even.


    class OddOrEven
    {
        static void Main()
        {
       Console.WriteLine("Number: ");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }

        }
    }

