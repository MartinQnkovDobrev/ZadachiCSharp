using System;


class Exchange
{
    static void Main()
    {
        int A = 5;
        int B = 10;
        Console.WriteLine("before exchange \u2192:A={0}\tB={1}",A,B );
        int C;
        C= A;
        A = B;
        B = C;

        Console.WriteLine("After exchange \u2192:A={0}\tB={1}",A,B);
    }
}

