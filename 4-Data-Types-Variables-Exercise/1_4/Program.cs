﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {

            string hexNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexNumber, 16));
            
        }
    }
}
