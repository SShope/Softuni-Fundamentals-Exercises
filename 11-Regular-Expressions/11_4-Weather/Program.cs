using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11_4_Weather
{
    class Weather
    {
        public string State { set; get; }
        public string Temp { set; get; }
        public string Type { set; get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string pattern = @"([A-Z]{2})(\d{1,2}?\.\d{1,2})([A-Za-z]+)\|";
            var weatherCol = new List<Weather>();
            string state, type, temp;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "end")
                    break;

                state = Regex.Match(input, pattern).Groups[1].ToString();
                temp = Regex.Match(input, pattern).Groups[2].ToString();
                type = Regex.Match(input, pattern).Groups[3].ToString();

                if (state == "" || state == null)
                {
                    continue;
                }
                if (!weatherCol.Exists(w => w.State == state))
                {
                    weatherCol.Add(new Weather { State = state, Temp = temp, Type = type });
                }
                else
                {
                    weatherCol.Find(w => w.State == state).Type = type;
                    weatherCol.Find(w => w.State == state).Temp = temp;
                    weatherCol.Find(w => w.State == state).State = state;
                }
            }

            weatherCol = weatherCol.OrderBy(w => float.Parse(w.Temp)).ToList();

            foreach (var w in weatherCol)
            {
                Console.WriteLine($"{w.State} => {float.Parse(w.Temp):F2} => {w.Type}");
            }
        }
    }
}
