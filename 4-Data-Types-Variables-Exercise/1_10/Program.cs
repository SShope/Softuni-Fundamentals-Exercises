using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10
{
    class Program
    {
        static void Main(string[] args)
        {

            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            ulong minutes = (ulong)(hours * 60);
            ulong seconds = minutes * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = " +
                $"{days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {seconds}000 milliseconds = " +
                $"{seconds}000000 microseconds = {seconds}000000000 nanoseconds");
        }
    }
}
