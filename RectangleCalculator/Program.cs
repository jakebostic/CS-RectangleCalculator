using System;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();

            Console.Write("Enter length: ");
            int length = Console.Read();
            Console.Write("Enter width: ");
            int width = Console.Read();
            Console.WriteLine();

            double area = width * length;
            double per = 2 * width + 2 * length;

            Console.WriteLine($"\nArea: {area}");
            Console.WriteLine($"\nPerimeter: {per}");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        
        }

    }
}
