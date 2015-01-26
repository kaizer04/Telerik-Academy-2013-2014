/*Write a program that parses an URL address given in the format:

		and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
		[protocol] = "http"
		[server] = "www.devbg.org"
		[resource] = "/forum/index.php"*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractsURLAdress
{
    static void Main()
    {
        Console.WriteLine("Extracts from URL an information");
        Console.Write("Enter URL adress: ");
        string s = Console.ReadLine();
        int protocolIndex = s.IndexOf(":");
        string protocol = s.Substring(0, protocolIndex);
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        int serverIndex = s.IndexOf("/", protocolIndex + 3);
        //Console.WriteLine(serverIndex);
        string server = s.Substring((protocolIndex + 3), (serverIndex - protocolIndex - 3));
        Console.WriteLine("[server] = \"{0}\"", server);
        string resource = s.Substring(serverIndex, s.Length - serverIndex);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}