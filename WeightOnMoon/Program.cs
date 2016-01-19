using System;


//The gravitational field of the Moon is approximately 17% of that on the Earth.
//   Write a program that calculates the weight of a man on the moon by a given weight on the Earth.



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            double number = double.Parse(Console.ReadLine());
            double result = number * 0.17;
            Console.WriteLine(result);


        }
    }

