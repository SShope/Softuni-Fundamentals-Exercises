﻿using System;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;

            Console.WriteLine($"{area:F2}");

        }
    }
}
