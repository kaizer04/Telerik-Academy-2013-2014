using System;

class BankAccountInfo
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance = 1.01m;
        string bankName = "UBB";
        string bic = "BG11 UBBS 7368 1234 5678 90";
        string iban = "UBBS BGSF";
        string creditCard1 = "5412 3334 5678 0809";
        string creditCard2 = "5641 3301 2345 6789";
        string creditCard3 = "8432 1234 3210 9876";
        Console.Write("Please, enter your full name:\nFirst name: ");
        firstName = Console.ReadLine();
        Console.Write("Middle name: ");
        middleName = Console.ReadLine();
        Console.Write("Last name: ");
        lastName = Console.ReadLine();
        Console.WriteLine("Your bank account information:\nBank: {0}\nBIC: {1}\nIBAN: {2}\nBalance to " + DateTime.Now + ": {3}BGN\nCredit Card 1: {4}\nCredit Card 2: {5}\nCredit Card 3: {6}", bankName, bic, iban, balance, creditCard1, creditCard2, creditCard3);

    }
}
