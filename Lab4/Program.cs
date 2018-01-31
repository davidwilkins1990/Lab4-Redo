/*
 David Wilkins
 Lab 4- Factorals
 01/22/18

 This program gets an input from the user and then finds its factoral 
 and displays it back to the user
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {

        public static long factoralForLoop(long input)
        {
            long result = 1;
            for (int i = 1; i < input; i++)
            {
                result = result * i;
            }

            return result;
        }


        public static long factoralRecursion(long input)
        {
            //stops the loop from continuing forever. 
           if (input == 0)
            {
                //0 returns 0, 2 returns double the actual answer.
                // ie with 4, it calls 4 * 3 * 2 * 1 * 1
                return 1; 
            }



            Console.WriteLine(input);
            return input * factoralRecursion(input - 1);
        }

        public static long factoralWhileLoop(long input)
        {
            long result = 1;

            while(input !=0 )
            {
                result = result * input;
                input = input - 1;
            }

            return result;
        }

        public static void userInput()
        {
            


            try
            {
                Console.WriteLine("***  Factorals   ***");
                


                Console.Write("Please enter an integer between 1 and 20: ");


                long input = long.Parse(Console.ReadLine());

                if (input < 1 || input > 20)
                {
                    Console.WriteLine("Integer MUST be between 1 and 20");
                    userInput();
                }

                Console.WriteLine("How would you like to solve this factoral? " +
                    "\nEnter '1' to use a For Loop \nEnter '2' to use a Recursive Method\n" +
                    "Enter '3' to use a While Loop: ");
                int caseInput = int.Parse(Console.ReadLine());

                switch (caseInput)
                {
                    case 1:
                        factoralForLoop(input);
                        Console.WriteLine();
                        break;
                    case 2:
                        factoralRecursion(input);
                        Console.WriteLine();
                        break;
                    case 3:
                        factoralWhileLoop(input);
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("\nYou must choose 1, 2, or 3...");
                        userInput();
                        break;

                }

                //calls factoral method and prints out the result
                Console.WriteLine("Result: " + factoralRecursion(input));


                Console.Write("\nPress 'Y' to enter a new number or any other key to exit: ");
                string again = "n";
                again = Console.ReadLine();
                again = again.ToLower();
                if (again == "y")
                {
                    Console.Clear();
                    userInput();
                }
                else
                {
                    Console.WriteLine("****    Goodbye!   ******");
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input - you must enter an integer between 1 and 10");
                userInput();
            }
        }
        static void Main(string[] args)
        {
            
            userInput();

            Console.ReadLine();
        }
    }
}
