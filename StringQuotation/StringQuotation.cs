using System;

class StringQuotation
{
    static void Main()
    {
        string Quote = "The \"use\" of quotations causes dificulities.";
        string OtherQ = @"The ""use"" of quotatisons causes dificulities.";
        Console.WriteLine("{0}\n{1}", Quote, OtherQ);
    }
}

