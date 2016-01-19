
//Write an expression that checks if given positive integer number n(n ≤ 100) is prime(i.e.it is divisible without remainder only to itself and 1).
//    Note: You should check if the number is positive
using System;

class NumberIsPrime
{
    static void Main()
    {
        
        Console.WriteLine("--- Primes between 0 and 100 ---");
        for (int i = 0; i < 100; i++)
        {
            bool prime = PrimeTool.IsPrime(i);
            if (prime)
            {
                Console.Write("Prime: ");
                Console.WriteLine(i);
            }
        }
    }
    public static class PrimeTool
    {
        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}