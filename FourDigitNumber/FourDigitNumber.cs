
//Write a program that takes as input a four-digit number in format abcd(e.g. 2011) and performs the following:
//      Calculates the sum of the digits(in our example 2 + 0 + 1 + 1 = 4).
//    Prints on the console the number in reversed order: dcba(in our example 1102).
//  Puts the last digit in the first position: dabc(in our example 1201).
//Exchanges the second and the third digits: acbd(in our example 2101).

//The number has always exactly 4 digits and cannot start with 0.


using System;




class FourDigitNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Four Digit Number:");
        //fourth digit
        int Number = int.Parse(Console.ReadLine());
        int FirstDigit = Number % 10;
        //Third Digit
        int RestNumberTwo = Number / 10;
        int SecondDigit = RestNumberTwo % 10;
        //Second Digit
        int RestNumberThree = Number / 100;
        int ThirdDigit = RestNumberThree % 10;
        //First digit 

        int RestNumberFour = Number / 1000;
        int FourthDigit = RestNumberFour % 10;

        Console.WriteLine("Number" + Number);
        Console.WriteLine("Sum of digits:" + (FirstDigit + SecondDigit + ThirdDigit + FourthDigit));
        Console.WriteLine("ReverseD:{0}{1}{2}{3}", FirstDigit, SecondDigit, ThirdDigit, FourthDigit);
        Console.WriteLine("Last digit in front {0}{1}{2}{3}", FirstDigit, FourthDigit, ThirdDigit, SecondDigit);
        Console.WriteLine("Second and third digits exchanged {0}{1}{2}{3}",FourthDigit,SecondDigit,ThirdDigit,FirstDigit);
















}
}

