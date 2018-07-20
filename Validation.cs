using System;

class Validation
{
    static void Main()
    {

    }

    static long ValidateLong(string userInput)
    {
        long num = 0;
        if (!long.TryParse(userInput, out num))
        {
            Console.WriteLine("Please enter a number.");
            num = 0;
        }
        else if (/*check if in range*/)
        {
            Console.WriteLine("Please enter a number in the given range.");
            num = 0;
        }
        else if (long.TryParse(userInput, out num))
        {
            num = long.Parse(userInput);
        }
        return num;
    }

    static int ValidateInt(string userInput)
    {
        int num = 0;
        if(!int.TryParse(userInput, out num))
        {
            Console.WriteLine("Please enter a number.");
            num = 0;
        }
        else if (/*check if in range*/)
        {
            Console.WriteLine("Please enter a number in the given range.");
            num = 0;
        }
        else
        {
            num = int.Parse(userInput);
        }
        return num;
    }

    static bool ValidateString(string userInput)
    {
        for (int i = 1; i < userInput.Length; i++)
        {
            if (int.TryParse(userInput[i]))
            {
                Console.WriteLine("Please enter a valid string");
                return false;
            }
        }
        return true;
    }
}