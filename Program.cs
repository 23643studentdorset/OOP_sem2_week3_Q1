using System;

namespace OOP_sem2_week3_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Write a program for a package delivery service. 
             * The program contains an array that holds the ten zip codes to which the company delivers packages. 
             * Prompt a user to enter a zip code and display a message indicating whether the zip code is one to which the company delivers.
             */

            string[] zipCodes = { "IRE4525", "UKK8690", "CHL7480", "GER7561", "BRZ948", "ARG295", "USA9563", "MEX5633", "COL5925", "FRA8593" };
            
            Console.WriteLine("Enter your zip code");
            string input = Console.ReadLine();
            bool flag = true;
            foreach (string i in zipCodes)
            {
                if (i.Equals(input))
                {
                    Console.WriteLine("We deliver to your city");
                    flag = false;   
                    break;
                }
            }


            if (flag)
            {
                Console.WriteLine("Sorry we don't deliver to your city");
            }
        }
    }
}
