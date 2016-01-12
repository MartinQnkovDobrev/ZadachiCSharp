using System;

class BankAccauntData
{
    static void Main()
    {
        string Name;
        string MiddleName;
        string LastName;
        int Balance;
        object BankName;
        long IBAN;
        ulong CredintCard1;
        ulong CreditCard2;
        ulong CreditCard3;

        Name = "Dancho";
        MiddleName = "Iotov";
        LastName = "Ganchev";
        Balance = 50000;
        BankName = "InvestBank";
        IBAN = 600555432361;
        CredintCard1 = 4454758923;
        CreditCard2 = 238472163231364;
        CreditCard3 = 15371274912323;
        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",Name,MiddleName,LastName,Balance,BankName,IBAN,CredintCard1,CreditCard2,CreditCard3);
            
    }
}

