using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Hello($"{Console.ReadLine()}");

        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
}
