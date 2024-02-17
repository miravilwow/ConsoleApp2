using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            String name = Console.ReadLine();

            Console.WriteLine("Enter the total number of your enrolled courses : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price of your favorite book :");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Name " + name);
            Console.WriteLine("Total enrolled courses : " + number);
            Console.WriteLine("Price of my favorite book : " + price);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}