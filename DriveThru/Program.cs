using System;
using System.Collections.Generic;

namespace DriveThru
{
    internal class Program
    {
        static int QuantitiesOfFood()
        {
            Console.Write("How many orders do you want?: ");
            int FoodQuantity = Convert.ToInt32(Console.ReadLine());
            return FoodQuantity;
        }
        static string FoodChoices() 
        {
            Console.WriteLine("What is your order? (TYPE 'done' if you want to exit): ");
            string FoodItem = Console.ReadLine();
            return FoodItem;
        }
            static void FoodMenu()
            {
                Console.WriteLine("Welcome to our drive thru!");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Here's our food menu");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Fries (49 Pesos)           Burger(79 Pesos");
                Console.WriteLine("Chicken Meal (109 Pesos)   Burger Steak (139 Pesos)");
                Console.WriteLine("Mojos (59 Pesos)           Hotshots (89 Pesos)");
                Console.WriteLine("Sundae (39 Pesos)          Coke (29 Pesos)");
                Console.WriteLine("Ice Cream (79 Pesos)       Sprite (29 Pesos)");
            }
            static void Main(string[] args)
            {
                List<string> Orders = new List<string>();
                List<int> Prices = new List<int>();
                List<int> Quantities = new List<int>();

                int totalCost = 0;

                FoodMenu();

                while (true)
                {

                   string FoodItem = FoodChoices();

                    if (FoodItem.ToLower() == "done")
                    {
                        break;
                    }

                    int FoodQuantity = QuantitiesOfFood();

                    int FoodPrice = 0;

                    if (FoodItem.ToLower() == "burger")
                    {
                        FoodPrice = 79;
                    }
                    else if (FoodItem.ToLower() == "fries")
                    {
                        FoodPrice = 49;
                    }
                    else if (FoodItem.ToLower() == "chicken meal")
                    {
                        FoodPrice = 109;
                    }
                    else if (FoodItem.ToLower() == "burger steak")
                    {
                        FoodPrice = 139;
                    }
                    else if (FoodItem.ToLower() == "mojos")
                    {
                        FoodPrice = 59;
                    }
                    else if (FoodItem.ToLower() == "hotshots")
                    {
                        FoodPrice = 89;
                    }
                    else if (FoodItem.ToLower() == "sundae")
                    {
                        FoodPrice = 39;
                    }
                    else if (FoodItem.ToLower() == "coke")
                    {
                        FoodPrice = 29;
                    }
                    else if (FoodItem.ToLower() == "ice cream")
                    {
                        FoodPrice = 79;
                    }
                    else if (FoodItem.ToLower() == "sprite")
                    {
                        FoodPrice = 29;
                    }
                    else
                    {
                        Console.WriteLine("Sorry we dont have it on our FOOD MENU!");
                        continue;
                    }

                    Orders.Add(FoodItem);
                    Prices.Add(FoodPrice);
                    Quantities.Add(FoodQuantity);
                    totalCost += FoodPrice * FoodQuantity;

                    Console.WriteLine("{0} x {1} added to your order (price: {2} Pesos) ", FoodQuantity, FoodItem, FoodPrice * FoodQuantity);
                }
                //summary of the orders
                Console.WriteLine("\nYour order summary:");
                for (int i = 0; i < Orders.Count; i++)
                {
                    Console.WriteLine("{0} x {1} - {2} Pesos", Quantities[i], Orders[i], Prices[i] * Quantities[i]);
                }

                Console.WriteLine("\nTotal cost: {0} Pesos", totalCost);


                while (true)
                {
                    Console.Write("Enter payment amount: P ");
                    int payment = 0;

                    // if the input user inputted a letter instead of numbers
                    try
                    {
                        payment = Convert.ToInt32(Console.ReadLine());
                        if (payment >= totalCost)
                        {
                            Console.WriteLine("Your payment is {0}. Your change is {1} Pesos. Thank you, come again!", payment, payment - totalCost);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, that payment amount is not enough to cover the total cost.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid payment amount. Please enter a valid number.");
                    }
                }


            }
        
    }
}