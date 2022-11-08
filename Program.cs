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
            
            //main menu options
            switch (Console.ReadLine())
            {
                //viewing present balance
                case "b":
                    Console.WriteLine("Your current balance is" + " $" + balance);
                    Menu();
                    Console.ReadKey();
                    break;
                    //deposting money
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
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Pick an option below to purchase a Plush Toy");
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Cat Plush - " + " $" + price2 + " [c]" );
                    Console.WriteLine("Dog Plush - " +" $" + price2 + " [d]");
                    Console.WriteLine("Polar Bear Plush - " +" $"+ price1 +" [p]");
                    Console.WriteLine("Bee Plush - " + " $" + price2 + " [b]");
                    Console.WriteLine("Red Panda Plush - "+" $" + price1 +" [r]");
                    Console.WriteLine("*********************************************************");

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
                            
                        default:
                            Console.WriteLine("Sorry, invaild option please try again");
                            Menu();
                            break;
                    }
                    
                    break; //end of category one

             //start of catergory two
                case "s":
                    Console.Clear();
                    int price3 = 20;
                    int price4 = 22;
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Pick an option below to purchase one of our Shirts");
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Ana's Shop Logo Shirt - " + " $" + price4 + " [a]");
                    Console.WriteLine("Bear Graphic Shirt - " + " $" + price4 + " [d]");
                    Console.WriteLine("Colourblock Shirt - " + " $" + price3 + " [c]");
                    Console.WriteLine("Cargo Shirt - " + " $" + price3 + " [b]");
                    Console.WriteLine("Amazing World of Gumball Shirt - " + " $" + price4 + " [w]");
                    Console.WriteLine("*********************************************************");

                    switch (Console.ReadLine())
                    {
                        case "a":
                            if (balance >= price4)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price4;
                                Console.WriteLine("You have brought the Ana's Shop Logo Shirt, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "d":
                            if (balance >= price4)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price4;
                                Console.WriteLine("You have brought the Bear Graphic Shirt, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "c":
                            if (balance >= price3)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price3;
                                Console.WriteLine("You have brought the Colourblock Shirt, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "b":
                            if (balance >= price3)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price3;
                                Console.WriteLine("You have brought the Cargo Shirt, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "w":
                            if (balance >= price4)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price4;
                                Console.WriteLine("You have brought the Amazing World of Gumball Shirt, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        default:
                            Console.WriteLine("Sorry, invaild option please try again");
                            Menu();
                            break;
                    }
                    
                 break; //end of category two

                    //start of category three
                case "a":
                    Console.Clear();
                    int price5 = 9;
                    int price6 = 11;
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Welcome");
                    Console.WriteLine("Pick an option below to purchase one of our Shirts");
                    Console.WriteLine("*********************************************************");
                    Console.WriteLine("Heart Necklace - " + " $" + price6 + " [h]");
                    Console.WriteLine("Ana's Shop Logo Pin - " + " $" + price5 + " [p]");
                    Console.WriteLine("Silver Mixed Charm Bracelet  - " + " $" + price5 + " [m]");
                    Console.WriteLine("Smiley Face Ring - " + " $" + price5 + " [s]");
                    Console.WriteLine("Cherry Necklace - " + " $" + price6 + " [c]");
                    Console.WriteLine("*********************************************************");


                    switch (Console.ReadLine())
                    {
                        case "h":
                            if (balance >= price6)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price6;
                                Console.WriteLine("You have brought the Heart Necklace, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "p":
                            if (balance >= price5)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price5;
                                Console.WriteLine("You have brought the Ana's Shop Logo Pin, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "m":
                            if (balance >= price5)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price5;
                                Console.WriteLine("You have brought the Silver Mixed Charm Bracelet, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "s":
                            if (balance >= price5)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price5;
                                Console.WriteLine("You have brought the Smiley Face Ring, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        case "c":
                            if (balance >= price6)
                            {
                                Console.WriteLine("Thank you for your purchase!");
                                balance = balance - price6;
                                Console.WriteLine("You have brought the Cherry Necklace, your balance is now" + " $" + balance);
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Error, not enough funds ");
                                Menu();
                            }
                            break;

                        default:
                            Console.WriteLine("Sorry, invaild option please try again");
                            Menu();
                            break;
                    }
                 break; //end of category three

                case "e":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Sorry, invaild option please try again");
                    Menu();
                    break;
            } 
        }

        
    }


}