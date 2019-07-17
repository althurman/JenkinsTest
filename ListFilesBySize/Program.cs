﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFilesBySize
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mydir = args[0];

            Console.WriteLine("My dir is: " + mydir);

            var sorted = Directory.GetFiles(mydir, "*.*", System.IO.SearchOption.AllDirectories).OrderBy(f => new FileInfo(f).Length);

            foreach (var f in sorted)
                Console.WriteLine(f + " " + new FileInfo(f).Length);




        }
    }
}
