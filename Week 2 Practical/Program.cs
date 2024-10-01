using System.Runtime.InteropServices.Marshalling;
using System.Security.Authentication;
using System.Transactions;
/*
 * Practical 2
 * Information: Methods demo
 * Version 1
 * Author Sophie Paton
 * Date: October 1st
 */

//Main();

void Main()
{
    int option = 0;
    do
    {
        PrintMenu();
        option = InputOption();
        GetMessage(option);
    }
    while (option == 0);
    {
        Console.ReadKey();
    }
}

//Prints menu options
void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");
}

// Get input from user
 static int InputOption()
{
    int option = 0;
    bool validInput = false;
    while (!validInput)
    {
        try
        {
            option = Convert.ToInt32(Console.ReadLine());
            if (option >= 0 && option <= 4)
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Input must be a number. Please try again");
        }
    }
    return option;
}
    


//Use option to get message chose
void GetMessage(int option)
    {
        switch (option)
        {
            case 0: Console.WriteLine("Goodbye");
                break;
            case 1:
                 Console.WriteLine("Bonjour!");
                break;
            case 2:
                 Console.WriteLine("Hola!");
                break;
        case 3:
                Console.WriteLine("Hallo!");
                break;
        case 4:
                Console.WriteLine("Ciao!");
                break;
        default:
                 Console.WriteLine("Please enter a valid option!");
                break;
    }
  }

Countwords();

void Countwords()
{
    Console.WriteLine("Enter a string where the first letter of each word is Uppercase:");
    
    string str = Console.ReadLine();
    string str_trim = str.Trim();
    int length = str_trim.Length;
    Console.WriteLine($"The sentence you inputted is: {str}.");

    String[] spaces = str_trim.Split(" ");
    int words = spaces.Length;

    Console.WriteLine($"Number of words = {words} ");
    Console.ReadKey();
}


Encrypt();

void Encrypt()
{
    Console.WriteLine("Enter a string:");
    string str = Console.ReadLine();
}
