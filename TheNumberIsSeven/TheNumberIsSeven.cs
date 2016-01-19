using System;

//Write an expression that checks for given integer if its third digit from right-to-left is 7

class TheNumberIsSeven

{
    static void Main()
    {
        Console.WriteLine("Input Number:");
        int A = int.Parse(Console.ReadLine());
        int B = (A / 100);
        int C = (B % 10);
        bool ThirdDigit = true;
        bool IsNot = false;
        if (C == 7)
        {

            Console.WriteLine("The third digit is 7:{0}",ThirdDigit);
        }
        else
        {
            Console.WriteLine("The third digit is not 7:{0}",false);
        }


    }
}