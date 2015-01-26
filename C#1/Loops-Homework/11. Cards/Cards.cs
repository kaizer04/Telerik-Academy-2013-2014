/*Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.*/

using System;

class Cards
{
    static void Main()
    {
        Console.WriteLine("All possible cards from a standard deck of 52 cards:");
        for (int cardNumber = 1; cardNumber <= 13; cardNumber++)
        {

            for (int cardSuit = 1; cardSuit <= 4; cardSuit++)
            {
                switch (cardNumber)
                {
                    case 1:
                        Console.Write("Ace of ");
                        break;
                    case 2: 
                        Console.Write("Two of ");
                        break;
                    case 3: 
                        Console.Write("Three of ");
                        break;
                    case 4: 
                        Console.Write("Four of ");
                        break;
                    case 5: 
                        Console.Write("Five of ");
                        break;
                    case 6: 
                        Console.Write("Six of ");
                        break;
                    case 7: 
                        Console.Write("Seven of ");
                        break;
                    case 8: Console.Write("Eight of ");
                        break;
                    case 9: Console.Write("Nine of ");
                        break;
                    case 10: Console.Write("Ten of ");
                        break;
                    case 11: Console.Write("Jack of ");
                        break;
                    case 12: Console.Write("Queen of ");
                        break;
                    case 13: Console.Write("King of ");
                        break;
                }
                switch (cardSuit)
                {
                    case 1: Console.WriteLine("Clubs");
                        break;
                    case 2: Console.WriteLine("Diamonds");
                        break;
                    case 3: Console.WriteLine("Hearts");
                        break;
                    case 4: Console.WriteLine("Spades");
                        break;
                }
            }
        }
    }
}