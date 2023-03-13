using System;

namespace OverlappingArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates, width and height of the first rectangle: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int w1 = Convert.ToInt32(Console.ReadLine());
            int h1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the coordinates, width and height of the second rectangle: ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int w2 = Convert.ToInt32(Console.ReadLine());
            int h2 = Convert.ToInt32(Console.ReadLine());

            int xOverlap = Math.Max(0, Math.Min(x1 + w1, x2 + w2) - Math.Max(x1, x2));
            int yOverlap = Math.Max(0, Math.Min(y1 + h1, y2 + h2) - Math.Max(y1, y2));

            int area = xOverlap * yOverlap;

            if (area > 8)
            {
                Console.WriteLine("Too Much Overlapping");
            }
            else if (area > 0)
            {
                Console.WriteLine("Not Much Overlapping");
            }
            else
            {
                Console.WriteLine("No Overlapping");
            }
        }
    }
}
