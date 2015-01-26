/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.*/

using System;

class InformationAboutCompanyAndManager
{
    static void Main()
    {
        Console.Write("Please, Enter an information about a company and its manager\nCompany name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company adress: ");
        string companyAdress = Console.ReadLine();
        Console.Write("Company Phone Number: ");
        ulong companyPhone = ulong.Parse(Console.ReadLine());
        Console.Write("Company Fax Number: ");
        ulong companyFax = ulong.Parse(Console.ReadLine());
        Console.Write("Company Web Site: ");
        string companySite = Console.ReadLine();
        Console.Write("Please, Enter a manager`s information:\nFirst name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Phone Number: ");
        ulong phone = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Information for {0}\nAdress: {1}\nPhone number: {2:+359 ### ### ## ##}\nFax number: {3:+359 ### ### ## ##}\nWeb site: {4}\nManager`s name: {5} {6}\nManager`s age: {7}\nManager`s phone {8:+359 #### ### ###}", companyName, companyAdress, companyPhone, companyFax, companySite, firstName, lastName, age, phone);
    }
}