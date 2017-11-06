using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11_8_Chains
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var contList = new List<string>();
            string pContents = null;

            contList = input.Split(new string[] { "<p>", "</p>" }, StringSplitOptions.None).ToList();

            for (int i = 1; i < contList.Count; i+=2)
            {
                pContents = pContents + contList[i] + " ";
            }

            char[] contentsCA = pContents.ToCharArray();
            char[] newChars = new char[contentsCA.Length];
            for (int i = 0; i < contentsCA.Length; i++)
            {
                int c = contentsCA[i];
                if (c < 48 || (c > 57 && c < 65) || (c > 90 && c < 97) || c > 122)
                {
                    newChars[i] = ' ';
                }
                else
                {
                    if (contentsCA[i] >= '0' && contentsCA[i] <= '9')
                    {
                        newChars[i] = contentsCA[i];
                    }
                    else if (contentsCA[i] < 'n')
                    {
                        newChars[i] = (char)(Convert.ToInt32(contentsCA[i]) + 13);
                    }
                    else
                    {
                        newChars[i] = (char)(Convert.ToInt32(contentsCA[i]) - 13);
                    }
                }
            }

            pContents = Regex.Replace(new String(newChars), @"\s+", " ");
            Console.WriteLine(pContents.Trim());
        }
    }
}
