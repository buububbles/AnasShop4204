using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnasShop4204
{
    internal class Program
    {
        public static string? name;
        public static int balance = 100;
        static void Main(string[] args)
        {   //welcoming message + users input for name
            Console.WriteLine("Hello! Welcome to Ana's Shop.");
            Console.WriteLine("Please enter your name to continue");
            name = Console.ReadLine();
            Menu();
        }

        public static void Menu()

        {
            int deposit;
            //main menu for shop with categories
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Ana's Shop");
            Console.WriteLine("Hello," + name);
            Console.WriteLine("Please choose an option below");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("View Balance - [b]");
            Console.WriteLine("Add Funds - [f]");
            Console.WriteLine("Purchase a Plush Toy - [t]");
            Console.WriteLine("Purchase a Shirt - [s]");
            Console.WriteLine("Purchase an Accessory - [a]");
            Console.WriteLine("Exit Shop - [e]");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

            switch (Console.ReadLine())
            {
                case "b":
                    Console.WriteLine("Your current balance is" + " $" + balance);
                    Menu();
                    Console.ReadKey();
                    break;

                case "f":
                    Console.WriteLine("Please add the number of fund you would like to");
                    deposit = int.Parse(Console.ReadLine());
                    Console.WriteLine("Thank you");
                    balance = balance + deposit;
                    Menu();
                    Console.ReadKey();
                    break;
                //category one start     
                case "t":
                    Console.Clear();
                    int price1 = 15;
                    int price2 = 12;
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Pick an option below to purchase a Plush Toy");
                    Console.WriteLine("Cat Plush - " + " $" + price2 + " [c]" );
                    Console.WriteLine("Dog Plush - " +" $" + price2 + " [d]");
                    Console.WriteLine("Polar Bear Plush - " +" $"+ price1 +" [p]");
                    Console.WriteLine("Bee Plush - " + " $" + price2 + " [b]");
                    Console.WriteLine("Red Panda Plush - "+" $" + price1 +" [r]");
        
                    switch (Console.ReadLine())
                    {
                        case "c":
                            if (balance >= price2)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price2;
                                Console.WriteLine("You have brought the Cat Plush, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "d":
                            if (balance >= price2)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price2;
                                Console.WriteLine("You have brought the Dog Plush, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "p":
                            if (balance >= price1)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price1;
                                Console.WriteLine("You have brought the Polar Bear Plush, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "b":
                            if (balance >= price2)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price2;
                                Console.WriteLine("You have brought the Bee Plush, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "r":
                            if (balance >= price1)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price1;
                                Console.WriteLine("You have brought the Red Panda Plush, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;
                    }
                    
                    break; //end of category one

             //start of catergory two
                case "s":

                    break;
            } 
        }

        
    }


}