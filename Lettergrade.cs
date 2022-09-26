using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lettergrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            Console.WriteLine("Enter your grade percentage:");
            double grade = Convert.ToDouble(Console.ReadLine());

                switch (grade)
                {
                    case double n when (n > 100 || n < 0):
                        Console.WriteLine("Invalid Input.");
                        Environment.Exit(0);
                        break;
                    case double n when (n <= 100 && n >= 90):
                        Console.WriteLine("Your Grade is an A.");
                        break;

                    case double n when (n < 90 && n >= 80):
                        Console.WriteLine("Your Grade is a B.");
                        break;

                    case double n when (n < 80 && n >= 70):
                        Console.WriteLine("Your Grade is a C.");
                        break;
                    case double n when (n < 70 && n >= 60):
                        Console.WriteLine("Your Grade is a D.");
                        break;
                    case double n when (n < 60 && n >= 0):
                        Console.WriteLine("Your Grade is an F.");
                        break;
                }
            }
        }
    }
}
