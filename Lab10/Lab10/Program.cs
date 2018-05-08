using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester!!");
            Circle circle1 = new Circle();
            double circumference = circle1.CalculateCircumference();
            double area = circle1.CalculateArea();
            int count = 0;
            bool repeat = true;
            while (repeat)
            {
                circle1.Radius = ValidateDouble("Enter a radius:");
                count++;
                PrintInfo(circle1);
                repeat = Continue("Would you like to do another circle?");
            }

            Console.WriteLine($"You created {count} circles");
            Console.WriteLine("Goodbye!");
        }
        static double ValidateDouble(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            while (!Regex.IsMatch(input, "^[0-9.]{1,}$"))
            {
                Console.WriteLine("\nInvalid input" + prompt);
                input = Console.ReadLine();
            }
            double radius = double.Parse(input);
            return radius;
        }
        static void PrintInfo(Circle circle1)
        {
            Console.WriteLine("Radius: " + circle1.Radius);
            Console.WriteLine("Circumference: "+circle1.CalculateFormattedCircumference());
            Console.WriteLine("Area: "+circle1.CalculateFormattedArea());
            

        }
        static bool Continue(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine().ToUpper();
                if (input == "N")
                {
                    return false;
                }
                else if (input == "Y")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                }
            }



        }
    }
}
