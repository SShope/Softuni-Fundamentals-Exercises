using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3_CircleIntersections
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] circle1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] circle2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Point center1 = new Point { X = circle1[0], Y = circle1[1] };
            Circle c1 = new Circle {Center = center1, Radius = circle1[2]};
            Point center2 = new Point { X = circle2[0], Y = circle2[1] };
            Circle c2 = new Circle { Center = center2, Radius = circle2[2] };

            if (CircleIntersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
	        {
                Console.WriteLine("No");
            }
            
        }

        static bool CircleIntersect(Circle circle1 , Circle circle2)
        {
            int xDiff = circle1.Center.X - circle2.Center.X;
            int yDiff = circle1.Center.Y - circle2.Center.Y;
            double centerDistance = Math.Sqrt(xDiff * xDiff + yDiff * yDiff);

            return centerDistance <= circle1.Radius + circle2.Radius;
        }
    }
}
