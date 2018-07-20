using System;

class Library
{
    /// <summary>
    /// This file is an example and snippet of my continue function
    /// it askes the user if they would like to continue using the program 
    /// based on their input we have three options, continue, stop or ask for valid input
    /// </summary>
    static void Main()
    {
        do
        {
            //code for program goes here
        }
        //call continue method
        while (Continue() == 1);
    }

    static int Continue()
    {
        string response;
        int situ = 3;
        while (situ == 3)
        {
            Console.WriteLine("Continue? (y/n): ");
            response = Console.ReadLine().ToLower();

            if (response == "y" || response == "yes")
            {
                //if yes, restart at main
                situ = 1;
            }
            else if (response == "n" || response == "no")
            {
                //if no, exit
                situ = 0;
            }
            else if (response != "n" || response != "no" || response != "y" || response != "yes")
            {
                situ = 3;
            }

            if (situ == 3)
            {
                Console.WriteLine("Please enter valid response.");
            }
        }
        return situ;
    }

    //static void Continue()
    //{
    //    string response;
    //    for (int i = 0; i < 5; i++)
    //    {
    //        Console.WriteLine("Continue? (y/n): ");
    //        response = Console.ReadLine().ToLower();

    //        if (response == "y" || response == "yes")
    //        {
    //            //if yes, restart at main
    //            Main();
    //        }
    //        else if (response == "n" || response == "no")
    //        {
    //            //if no, exit
    //            i = 5;
    //            return;
    //        }

    //        if (i <= 2 && response != "n" && response != "no" && response != "y" && response != "yes")
    //        {
    //            //if the user enters neither, inform and repeat
    //            Console.WriteLine("Sorry, I could not understand your response.");
    //            Console.WriteLine("Please enter a valid response.");
    //        }
    //        else if (i == 3 && response != "n" && response != "no" && response != "y" && response != "yes")
    //        {
    //            Console.WriteLine("Sorry, I could not understand your response.");
    //            Console.WriteLine("If a vaild response is not entered on this attempt the program will end");
    //        }
    //        else if (i == 4 && response != "n" && response != "no" && response != "y" && response != "yes")
    //        {
    //            Console.WriteLine("Sorry, I could not understand your response.");
    //            Console.WriteLine("You have run out of continue attempts and the program has terminated.");
    //        }
    //    }
    //    return;
    //}
}