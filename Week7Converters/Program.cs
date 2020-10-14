using System;

namespace Week7Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If you want convert Celsius to Fahrenheit or Fahrenheit type (A)." +
                "If you want convert Fahrenheit into Celsius type (B).");
            string userchoise = Console.ReadLine().ToLower();
            bool correctans = false;
            while (!correctans)
            {
                userchoise = Console.ReadLine().ToLower();
                if (userchoise == "a")
                {
                    Farencal();
                    correctans = true;
                }
                else if (userchoise == "b")
                {
                    Celsiuscal();
                    correctans = true;
                }
                else
                {
                    Console.WriteLine("Type A or B !!!");
                }
            }
        }
                public static void Farencal()
                {
                    Console.WriteLine("Enter Celsius.");
                    double userinput = double.Parse(Console.ReadLine());
                    double faren = (userinput * 9) / 5 + 32;
                    Console.WriteLine($"farenheit: {faren}");
                }
                public static void Celsiuscal()
                {
                    Console.WriteLine("Enter Farenheit.");
                    double userinput = double.Parse(Console.ReadLine());
            double celc = (userinput - 32) * 5 / 9;
                    Console.WriteLine($"Celsius: {celc}");
                }


            }
        }

