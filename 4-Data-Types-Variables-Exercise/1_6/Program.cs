using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_6
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "Hello";
            string str2 = "World";
            object obj1 = str1 + " " + str2;
            string str3 = obj1.ToString();

            Console.WriteLine(str3);

        }
    }
}
