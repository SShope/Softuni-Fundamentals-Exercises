using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_17
{
    class Program
    {
        static void Main(string[] args)
        {
            int startCharIndex = int.Parse(Console.ReadLine());
            int endCharIndex = int.Parse(Console.ReadLine());
           
            for (int i = startCharIndex; i <= endCharIndex; i++)
            {

                Console.Write($"{Convert.ToChar(i)} ");
            }

        }
    }
}
