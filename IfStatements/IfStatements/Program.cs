using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //bool isGoldCustomer = true;

            //float price = (isGoldCustomer) ? 19.95f : 29.95f;

            //Console.WriteLine(price);
            //var season = Season.Winter;

            //switch (season)
            //{
            //    case Season.Autumn:
            //    case Season.Summer:
            //        Console.WriteLine("you can use the same output for multiple case");
            //        break;

            //    default:
            //        Console.WriteLine("default option");
            //        break;
            //}

            {
                //exercise 1 1- Write a program and ask the user to enter a number. 
                //The number should be between 1 to 10. If the user enters a valid number, 
                //display "Valid" on the console. Otherwise, display "Invalid". 
                //(This logic is used a lot in applications where values entered into input boxes need to be validated.)

                Console.WriteLine("Enter a number between 1 & 10:");
                int valueEntered = Convert.ToInt16(Console.ReadLine());

                if (valueEntered > 0 && valueEntered < 10)
                {
                    Console.WriteLine("Valid");
                }

                else
                {
                    Console.WriteLine("invalid number");
                }
            }
        }
    }
}
