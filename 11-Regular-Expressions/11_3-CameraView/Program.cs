using System;
using System.Linq;
using System.Collections.Generic;

namespace _11_3_CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int skip = elements[0];
            int take = elements[1];

            string input = Console.ReadLine();
            string[] views = input.Split(new string[] { "|<" }, StringSplitOptions.None);
            var pictures = new List<string>();

            for (int i = 1; i < views.Length; i++)
            {
                if (views[i].Length < skip + take)
                {
                    pictures.Add(views[i].Substring(skip));
                }
                else
                {
                    pictures.Add(views[i].Substring(skip,take));
                }
            }
            Console.WriteLine(String.Join(", ", pictures));

        }

    }
}
