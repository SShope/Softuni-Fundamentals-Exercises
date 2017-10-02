using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_13
{
    class Program
    {
        static void Main(string[] args)
        {

            char character = char.Parse(Console.ReadLine());

            if (character >= 48 && character <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u' ||
                character == 'A' || character == 'E' || character == 'I' || character == 'O' || character == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }

        }
    }
}
