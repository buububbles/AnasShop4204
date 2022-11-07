using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnasShop4204
{
    internal class Program
    {
        public static string? name;
        static void Main(string[] args)
        {   //welcoming message + users input for name
            Console.WriteLine("Hello! Welcome to Ana's Shop.");
            Console.WriteLine("Please enter your name to continue");
            name = Console.ReadLine();
            Menu();
        }

        public static void Menu()
        {  //main menu for shop with categories
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Ana's Shop");
            Console.WriteLine("Hello," + name);
            Console.WriteLine("Please choose an option below");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("View Balance - [b]");
            Console.WriteLine("Add Funds - [f]");
            Console.WriteLine("Plush Toys - [p]");
            Console.WriteLine("Fidget Toys - [t]");
            Console.WriteLine("Candy - [c]");
            Console.WriteLine("Shirts - [s]");
            Console.WriteLine("Accessories - [a]");
            Console.WriteLine("Previous Purcahses - [p]");
            Console.WriteLine("Exit Shop - [e]");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        }
    }


}