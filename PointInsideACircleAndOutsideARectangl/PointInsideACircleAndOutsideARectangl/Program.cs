//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)


using System;




class PointInsideACircleAndOutsideARectangl
{
    static void Main()
    {
        Console.Write("Please enter Xc and Yc\n Xc = ");

        float Xc = float.Parse(Console.ReadLine());

        Console.Write(" Yc = ");

        float Yc = float.Parse(Console.ReadLine());

        double Radious = 1.5 * 1.5;
        int CircleX = 1;
        int CircleY = 1;


        double PointsCoordinates = (CircleX - Xc) * (CircleX - Xc) + (CircleY - Yc) * (CircleY - Yc);
        bool InCircle = Radious - PointsCoordinates >= 0;
        bool InRectangle = Xc >= -1 && Xc <= 5 && Yc >= -1 && Yc <= 1;
        if (InCircle && InRectangle)

        {

            Console.WriteLine("\nThe point wirh coordinates ( {0} : {1} ) is in the both figures!\n", Xc, Yc);

        }

        if (InCircle && !InRectangle)

        {

            Console.WriteLine("\nThe point wirh coordinates ( {0} : {1} ) is in the circle and out of the rectangle!\n", Xc, Yc);

        }

        if (!InCircle && InRectangle)

        {

            Console.WriteLine("\nThe point wirh coordinates ( {0} : {1} ) is in the rectangle and out of the cirlce!\n", Xc, Yc);

        }

        if (!InCircle && !InRectangle)

        {

            Console.WriteLine("\nThe point wirh coordinates ( {0} : {1} ) is outside both figures!\n", Xc, Yc);

        }

    }

}












