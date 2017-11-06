using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _11_2_ExtractSentanceByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = @"\b[^?.!]*\b" + word + @"\b[^?.!]*";
           
            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m.ToString().Trim());
            }
        }
    }
}
