
//Write an expression that calculates trapezoid's area by given sides a and b and height h.


using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter Side A of the trapezoid");
        double A = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side B of the trapezoid");
        double B = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the high (H) of the trapezoid");
        double H = double.Parse(Console.ReadLine());



        double Area = ((A + B) / 2.0) * H;

        Console.WriteLine("The area of your trapezoid is :{0}",Area);
        


    }
}

