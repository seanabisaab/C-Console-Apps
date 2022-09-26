using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a distance in miles.");
            string miles1 = Console.ReadLine();
            double miles = Convert.ToDouble(miles1);
            double km = miles * 1.609;
            Console.WriteLine("That is " + km + " kilometers.");
            
   
        }
    }
}
