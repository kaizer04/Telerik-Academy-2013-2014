﻿namespace _02_DirectoryTraverser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main()
        {
            ExeFinder finder = new ExeFinder();
            finder.GetSubDirectories(@"D:");
        }
    }
}
