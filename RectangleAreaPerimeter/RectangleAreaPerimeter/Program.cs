//Write an expression that calculates rectangle’s perimeter and area by given width and height.
using System;



class RectanglePerimeterAndSide

{
    static void Main()
    {
        int Wight;
        int Height;
        int Perimeter;
        int Area;

        Console.WriteLine("Weight of the rectangle:");

        Wight = int.Parse(Console.ReadLine());

        Console.WriteLine("Height of the rectangle:");

        Height = int.Parse(Console.ReadLine());

        Console.WriteLine("The perimeter of the rectangle(P) is:");
        Console.WriteLine("");
        Console.Write(Perimeter = 2 * Wight + 2 * Height);
        Console.WriteLine("");
        Console.WriteLine("The area of the rectangle(S) is:");
        Console.WriteLine("");
        Console.Write(Area = Wight * Height);

        Console.WriteLine();
    }
}
