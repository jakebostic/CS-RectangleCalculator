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
            if (double.TryParse(Console.ReadLine(), out double length))
            {
                Console.Write("Enter width: ");
                if (double.TryParse(Console.ReadLine(), out double width))
                {
                    double area = width * length;
                    double per = 2 * width + 2 * length;
                    Console.WriteLine($"\nArea: {area}");
                    Console.WriteLine($"\nPerimeter: {per}");
                }

                Console.Write("Press any key to exit...");
                Console.ReadKey(true);
            }
            
        
        }

    }
}
