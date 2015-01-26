using System;

class FirmRecordEmployees
{
    static void Main()
    {
        string firstName;
        string familyName;
        byte age = 34;
        char gender = 'm';
        ulong idNumber = 7904299087u; //приемам, че това е българско ЕГН
        uint uniqueENumber = 27569999u;
        Console.Write("Please, Enter employee full name:\nFirst name: ");
        firstName = Console.ReadLine();
        Console.Write("Family name: ");
        familyName = Console.ReadLine();
        Console.WriteLine("Information for an Employee - {0} {1}:\nAge: {2}\nGender: {3}\nID number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, uniqueENumber);
        //Console.Write("Age: ");
        //age = byte.Parse(Console.ReadLine());
        //Console.Write("Gender(m/f): ");
        //gender = Console.ReadLine();
        
        //Console.WriteLine(firstName);
        //Console.WriteLine(familyName);

      
        //Console.ReadLine("Age: {0}", age);
        //Console.ReadLine("Gender(m/f): {0}", gender);
        //Console.ReadLine("ID number: {0}", idNumber);
        //Console.ReadLine("Unique employee number (27560000 to 27569999): {0}", uniqueENumber);
    }
}

