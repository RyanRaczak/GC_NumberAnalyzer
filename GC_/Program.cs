using System;

namespace GC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask user name and refer throughout
            //Prompt for user input
            //Validate input int 1 and 100
            //If odd - Print number and Odd
            //If even and inclusive range of 2-25, print Even and less then 25
            //If even and inclusive range 26-60, print Even, greater then 25 but less then 61
            //If even and >60, print number and Even
            //If odd and >60, print number and Odd
            //Add parameter so program officially ends

            //Welcome/Ask for userName
            Console.WriteLine("Welcome to the Number Analyzer!");
            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nHello {userName}. Let's begin...\n");

            bool repeatProgram = true;
            while (repeatProgram)
            {
                int userInput;
                //Makes sure input is 1-100
                while (true)
                {
                    Console.Write("\nPlease enter an integer 1-100: ");
                    string sInput = Console.ReadLine();
                    if (int.TryParse(sInput,out userInput))
                    {
                        if (userInput > 0 && userInput <= 100)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Number...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Number...");
                    }
                }

                //Checking conditions
                if (userInput % 2 == 1 && userInput > 60)
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is ODD and GREATER than 60");
                }

                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is EVEN and GREATER than 60");
                }

                else if (userInput % 2 == 0 && userInput > 25 && userInput <= 60)
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is EVEN and GREATER than 25 but LESS than 61");
                }

                else if (userInput % 2 == 0 && userInput > 1 && userInput < 25)
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is EVEN but LESS than 25");
                }

                else if (userInput % 2 == 1)
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is ODD");
                }

                else
                {
                    Console.WriteLine($"\n{userName}, the number you entered was {userInput}.\n" +
                        $"{userInput} is clearly a magical number and that's how you ended up here.");
                }

                //Checks if user wants to continue & input is valid
                while (true)
                {
                    Console.Write("\nWould you like to run the program again? (y/n): ");
                    string userContinue = Console.ReadLine().ToLower();
                    if (userContinue == "y")
                    {
                        repeatProgram = true;
                        break;
                    }
                    else if (userContinue == "n")
                    {
                        repeatProgram = false;
                        Console.WriteLine("\nThank you for using Number Analyzer!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInput is invalid...");
                    }
                }

            }
        }
    }
}
