﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //CONDITIONALS EXERCISES
            //    //exercise 1 1- Write a program and ask the user to enter a number. 
            //    //The number should be between 1 to 10. If the user enters a valid number, 
            //    //display "Valid" on the console. Otherwise, display "Invalid". 
            //    //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
            //    {
            //        Console.WriteLine("Enter a number between 1 & 10:");
            //    var valueEntered = float.Parse(Console.ReadLine());

            //    if (valueEntered > 0 && valueEntered < 10)
            //    {
            //        Console.WriteLine("Valid");
            //    }

            //    else
            //    {
            //        Console.WriteLine("invalid number");
            //    }
            //}



            //    ////2 - Write a program which takes two numbers from the console and displays the maximum of the two.
            //    {
            //        Console.WriteLine("Enter first number");
            //        int firstNumber = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter second number");
            //        int secondNumber = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Greatest of two: " + Functions.GetMax(firstNumber, secondNumber));
            //    }



            //    //3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

            //    {
            //        Console.WriteLine("Enter the Height");
            //        int height = int.Parse(Console.ReadLine());

            //        Console.WriteLine("Enter the Width");
            //        int width = int.Parse(Console.ReadLine());

            //        if (height > width)
            //        {
            //            Console.WriteLine("the image is portrait");
            //        }

            //        else if (width > height)
            //        {
            //            Console.WriteLine("the Image is landscape");
            //        }

            //        else
            //        {
            //            Console.WriteLine("the Image is Square");
            //        }



            //        //4 - Your job is to write a program for a speed camera.  For simplicity, 
            //        //ignore the details such as camera, sensors, etc and focus purely on the logic.
            //        //Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
            //        //If the user enters a value less than the speed limit, program should display Ok on the console.
            //        //If the value is above the speed limit, the program should calculate the number of demerit points.
            //        //For every 5km / hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            //        //If the number of demerit points is above 12, the program should display License Suspended.

            //        {
            //            Console.WriteLine("whats the Speed Limit?");
            //            int speedLimit = int.Parse(Console.ReadLine());

            //            Console.WriteLine("how fast was the car Travelling?");
            //            int speedOfCar = int.Parse(Console.ReadLine());
            //        }



            //LOOPS Exercises
            //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            ////Display the count on the console.
            //{
            //    for (var i = 0; i <= 100; i++)
            //    {
            //        if (i % 3 == 0)
            //            Console.WriteLine(i);
            //    }

            //}




            ////2- Write a program and continuously ask the user to enter a number or "ok" to exit. 
            //Calculate the sum of all the previously entered numbers and display it on the console.

            string strNum;
            int num;
            int i = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Please enter a number or ok to exit");
                strNum = Console.ReadLine();
                if (int.TryParse(strNum, out num))
                {
                    sum += num;
                    Console.WriteLine("The total is {1}", i, sum);
                    continue;
                }
                else
                {
                    if (strNum == "ok")
                        break;
                }

            }
            while (true);
        }
    }
}

