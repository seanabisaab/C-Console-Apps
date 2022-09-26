using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            for (int i = 0; i < 3; i++) { 
            Console.WriteLine("What would you like to compute the area of:" +
                "\n1. circle" +
                "\n2. rectangle" +
                "\n3. cylinder");
            double s1 = Convert.ToDouble(Console.ReadLine());
            if (s1 == 1)
            {
                Console.WriteLine("Enter the radius of the circle:");
                double r = Convert.ToDouble(Console.ReadLine());
                double a = Math.PI * r * r;

                Console.WriteLine("The area or the circle is " + a.ToString("0.000"));
            }
            else if (s1 == 2)
            {
                Console.WriteLine("Enter height of the rectangle:");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter width of the rectangle:");
                double w = Convert.ToDouble(Console.ReadLine());
                double a = w * h;

                Console.WriteLine("The area or the rectangle is " + a.ToString("0.000"));
            }
            else if (s1 == 3)
            {
                Console.WriteLine("Enter radius of the cylinder:");
                double r2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height of the cylinder:");
                double h2 = Convert.ToDouble(Console.ReadLine());
                double a = (2 * Math.PI * r2 * h2) + (2 * Math.PI * r2 * r2);

                Console.WriteLine("The area or the rectangle is " + a.ToString("0.000"));
            }
            }
        }
    }
}
