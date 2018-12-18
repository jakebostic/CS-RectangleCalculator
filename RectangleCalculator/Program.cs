using System;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");
            Console.WriteLine();

            Scanner sc = new Scanner(Console.Read().ToString());
            string choice = "y";
            while (choice.Equals("y"))
            {
                    double length = GetDoubleWithinRange(sc, "Enter length: ", 0, 1000000);
                    double width = GetDoubleWithinRange(sc, "Enter width: ", 0, 1000000);

                        double area = width * length;
                        double per = 2 * width + 2 * length;

                        Console.WriteLine($"\nArea: {area}");
                        Console.WriteLine($"\nPerimeter: {per}");
                        Console.WriteLine();
                    
                    Console.Write("Continue? (y/n)");
                    choice = Console.ReadLine();

            }

        }
        private static double GetDouble(Scanner sc, String prompt)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (sc.HasNextDouble())
                {
                    d = sc.NextDouble();
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Error! Invalid decimal value. Try again.");
                }
                Console.Read();
            }
            return d;
        }

        private static double GetDoubleWithinRange(Scanner sc, String prompt, double min, double max)
        {
            double d = 0;
            bool isValid = false;
            while (!isValid)
            {
                d = GetDouble(sc, prompt);
                if (d <= min)
                {
                    Console.WriteLine("Error! number must be greater than " + min);
                }
                else if (d >= max)
                {
                    Console.WriteLine("Error! number must be less than " + max);
                }
                else
                {
                    isValid = true;
                }
            }
            return d;
        }

    }

}
