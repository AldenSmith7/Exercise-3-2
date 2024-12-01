using System;

class Program
{
    public static void Main()
    {
        Console.Write("Enter wind speed in mph: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        if (windSpeed >= 74)
        {
            int category = 0;

            if (windSpeed >= 157)
            {
                category = 5;
            }
            else if (windSpeed >= 130)
            {
                category = 4;
            }
            else if (windSpeed >= 111)
            {
                category = 3;
            }
            else if (windSpeed >= 96)
            {
                category = 2;
            }
            else
            {
                category = 1;
            }

            Console.WriteLine("This is a category " + category + " hurricane");
        }
        else
        {
            Console.WriteLine("This is not a hurricane.");
        }
    }
}