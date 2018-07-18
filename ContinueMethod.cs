using System;

class Library
{
    static void Main()
    {
        //This File is an example of my Continue Method
        Continue();
    }

    static void Continue()
    {
        string response;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Continue? (y/n): ");
            response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                //if yes, restart at main
                Main();
            }
            else if (response == "n" || response == "no")
            {
                //if no, exit
                i = 5;
                return;
            }

            if (i <= 2 && response != "n" && response != "no" && response != "y" && response != "yes")
            {
                //if the user enters neither, inform and repeat
                Console.WriteLine("Sorry, I could not understand your response.");
                Console.WriteLine("Please enter a valid response.");
            }
            else if (i == 3 && response != "n" && response != "no" && response != "y" && response != "yes")
            {
                Console.WriteLine("Sorry, I could not understand your response.");
                Console.WriteLine("If a vaild response is not entered on this attempt the program will end");
            }
            else if (i == 4 && response != "n" && response != "no" && response != "y" && response != "yes")
            {
                Console.WriteLine("Sorry, I could not understand your response.");
                Console.WriteLine("You have run out of continue attempts and the program has terminated.");
            }
        }
        return;
    }
}