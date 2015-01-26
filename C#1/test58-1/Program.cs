using System;

class IntDoubleOrStringVariableInput
{
    static void Main()
    {
        Console.WriteLine("Choose an int, double or string variable and enter it!");
        string x = Console.ReadLine(); 
       
        double doublex;
        bool y = double.TryParse(x, out doublex);

        
        switch (y)
        {
            case true:
                Console.WriteLine("This variable is of int type and its value is {0}!", doublex + 1);
                break; 
            case false:
                Console.WriteLine("This variable is of string type and its value is {0}*!", x);
                break; 
        }
    }
}