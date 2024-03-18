
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter F or C to convert  to the desired temperature, type quit to exit the program");
        string? input = Console.ReadLine();

        if (input == "F")
        {
            F_to_C();
        }
        else if (input == "C")
        {
            C_to_F();
        }

        else if (input == "quit")
        {
            while (true)
            {
                break;
            }
        }

        else
        {
            Console.WriteLine("Invalid Input! Please enter F or C ");
        }


        void C_to_F()
        {
            Console.WriteLine("enter temperature here C: ");
            double celsuis = Convert.ToDouble(Console.ReadLine());
            double fahrenhiet = celsuis * 9 / 5 + 32;
            Console.WriteLine($"tempreature in fehrenheit is: {fahrenhiet:F2}'F");
        }

        void F_to_C()
        {
            Console.WriteLine("enter temperature here F: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsuis = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"tempreature in Celsuis is: {celsuis:F2}'C");
        }
    }
}