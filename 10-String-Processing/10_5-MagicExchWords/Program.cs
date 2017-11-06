using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_MagicExchWords
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();
            string w1 = input[0].ToLower();
            string w2 = input[1].ToLower();
            string diff = null;

            if (w1.Length > w2.Length)
            {
                diff = w1.Substring(w2.Length);
            }
            else if (w1.Length < w2.Length)
            {
                diff = w2.Substring(w1.Length);
            }

            var mapping = new Dictionary<char, char>();
            bool isExch = true;

            for (int i = 0; i < Math.Min(w1.Length, w2.Length); i++)
            {
                if (!mapping.ContainsKey(w1[i]))
                {
                    mapping.Add(w1[i], w2[i]);
                }
                else
                {
                    if (mapping[w1[i]] != w2[i] || mapping.ContainsValue(w1[i]))
                    {
                        isExch = false;
                        break;
                    }
                }
            }

            if (diff != null)
            {
                foreach (var letter in diff)
                {
                    if (!mapping.ContainsKey(letter))
                    {
                        isExch = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isExch.ToString().ToLower());
        }
    }
}
