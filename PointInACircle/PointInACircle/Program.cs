//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;



class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter X coordinates:");
        double Xp = double.Parse(Console.ReadLine());
        Console.WriteLine("Ënter Y coordinates:");
        double Yp = double.Parse(Console.ReadLine());

        //Circle center coordinates
        double Xh = 0;
        double Yk = 0;
        Double Radius = 2;


        double Distance = (Xp - Xh) * (Xp - Xh) + (Yp - Yk) * (Yp - Yk);
        if (Distance <= Radius)
        {
            Console.WriteLine("The point is inside the circle");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }


    }
}

