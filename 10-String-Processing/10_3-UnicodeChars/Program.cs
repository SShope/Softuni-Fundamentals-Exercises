using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_UnicodeChars
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                Console.Write(@"\u" + ((int)letter).ToString("X4").ToLower());
            }


        }
    }
}
