using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Line 1
                double xa1 = double.Parse(Console.ReadLine());
                double ya1 = double.Parse(Console.ReadLine());
                double xa2 = double.Parse(Console.ReadLine());
                double ya2 = double.Parse(Console.ReadLine());

                // Line 2
                double xb1 = double.Parse(Console.ReadLine());
                double yb1 = double.Parse(Console.ReadLine());
                double xb2 = double.Parse(Console.ReadLine());
                double yb2 = double.Parse(Console.ReadLine());

                if (GetLineLenght(xa1, ya1, xa2, ya2) >= GetLineLenght(xb1, yb1, xb2, yb2))
                {
                    Console.WriteLine(ReturnClosestPoint(xa1, ya1, xa2, ya2) + ReturnFarthestPoint(xa1, ya1, xa2, ya2));
                }
                else
                {
                    Console.WriteLine(ReturnClosestPoint(xb1, yb1, xb2, yb2) + ReturnFarthestPoint(xb1, yb1, xb2, yb2));
                }
                

            }

            static decimal GetLineLenght(double x1, double y1, double x2, double y2)
            {
                decimal lenghtOfLine = (decimal)Math.Sqrt(
                    (Math.Abs(x1) + Math.Abs(x2)) * (Math.Abs(x1) + Math.Abs(x2)) + 
                    (Math.Abs(y1) + Math.Abs(y2)) * (Math.Abs(y1) + Math.Abs(y2))
                    );
                return lenghtOfLine;
            }
            
            static string ReturnClosestPoint(double x1, double y1, double x2, double y2)
            {
                decimal distanceOne = (decimal)Math.Sqrt(x1 * x1 + y1 * y1);
                decimal distanceTwo = (decimal)Math.Sqrt(x2 * x2 + y2 * y2);
                string closestPoint = null;

                if (distanceOne > distanceTwo)
                {
                    return closestPoint = $"({x2}, {y2})";
                }
                else
                {
                    return closestPoint = $"({x1}, {y1})";
                }

            }
            static string ReturnFarthestPoint(double x1, double y1, double x2, double y2)
            {
                decimal distanceOne = (decimal)Math.Sqrt(x1 * x1 + y1 * y1);
                decimal distanceTwo = (decimal)Math.Sqrt(x2 * x2 + y2 * y2);
                string farestPoint = null;

                if (distanceOne <= distanceTwo)
                {
                    return farestPoint = $"({x2}, {y2})";
                }
                else
                {
                    return farestPoint = $"({x1}, {y1})";
                }

            }

        }
    }