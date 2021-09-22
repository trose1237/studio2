using System;

namespace studio2
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius; 
            double pi = Math.PI;
            double mpg;

            Console.WriteLine("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(2, radius);
            Console.WriteLine("The area of a cirlce of radius " + radius + " is " + area);
            double circumference = 2 * pi * radius;
            Console.WriteLine("The circumference of radius " + radius + " is " + circumference);
            double diameter = 2 * radius;
            Console.WriteLine("The diameter of radius " + radius + " is " + diameter);
            Console.WriteLine("What are the MPG of your car?");
            mpg = double.Parse(Console.ReadLine());
            double roadTrip = circumference / mpg;
            Console.WriteLine("You will have to travel " + roadTrip + " miles around the cirle.");
        
        }
    }
}
