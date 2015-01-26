

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zerg___
{
    class Program
    {
        static void NumeralSystem(string stringnumber)
        {
            int length = stringnumber.Length;

            int opposite = stringnumber.Length - 1;

            double result = 0;

            double pow = 0;

            int NumeralSystemBase = 15;

            for (int i = 0; i < length; i++)
            {
                switch (stringnumber[i])
                {
                    case '0': pow = 0;
                        break;
                    case '1': pow = 1;
                        break;
                    case '2': pow = 2;
                        break;
                    case '3': pow = 3;
                        break;
                    case '4': pow = 4;
                        break;
                    case '5': pow = 5;
                        break;
                    case '6': pow = 6;
                        break;
                    case '7': pow = 7;
                        break;
                    case '8': pow = 8;
                        break;
                    case '9': pow = 9;
                        break;
                    case 'A': pow = 10;
                        break;
                    case 'B': pow = 11;
                        break;
                    case 'C': pow = 12;
                        break;
                    case 'D': pow = 13;
                        break;
                    case 'E': pow = 14;
                        break;

                }
                result += pow * Math.Pow(NumeralSystemBase, opposite);
                opposite--;
            }

            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string tempMessage = null;
            string messageToConvert = null;
            int messageLength = 0;

            switch (message.Length)
            {
                case 4: messageLength = 1;
                    break;
                case 8: messageLength = 2;
                    break;
                case 12: messageLength = 3;
                    break;
                case 16: messageLength = 4;
                    break;
                case 20: messageLength = 5;
                    break;
                case 24: messageLength = 6;
                    break;
                case 28: messageLength = 7;
                    break;
                case 32: messageLength = 8;
                    break;
                case 36: messageLength = 9;
                    break;
            }
            int start = 0;
            int end = 4;

            for (int i = 0; i < messageLength; i++)
            {
                for (int j = start; j < end; j++)
                {
                    tempMessage += message[j];
                }
                start += 4;
                end += 4;

                switch (tempMessage)
                {
                    case "Rawr": messageToConvert += "0";
                        break;
                    case "Rrrr": messageToConvert += "1";
                        break;
                    case "Hsst": messageToConvert += "2";
                        break;
                    case "Ssst": messageToConvert += "3";
                        break;
                    case "Grrr": messageToConvert += "4";
                        break;
                    case "Rarr": messageToConvert += "5";
                        break;
                    case "Mrrr": messageToConvert += "6";
                        break;
                    case "Psst": messageToConvert += "7";
                        break;
                    case "Uaah": messageToConvert += "8";
                        break;
                    case "Uaha": messageToConvert += "9";
                        break;
                    case "Zzzz": messageToConvert += "A";
                        break;
                    case "Bauu": messageToConvert += "B";
                        break;
                    case "Djav": messageToConvert += "C";
                        break;
                    case "Myau": messageToConvert += "D";
                        break;
                    case "Gruh": messageToConvert += "E";
                        break;
                }
                tempMessage = null;
            }
            NumeralSystem(messageToConvert);
        }
    }
}

