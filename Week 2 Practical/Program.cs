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

//Countwords();

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
//task_6();
void task_6()
{
    //Print text for the user to input string
    Console.WriteLine("Enter a string:");
    string str = Console.ReadLine();
    //print test for user to enter itterations
    Console.WriteLine("Enter number of rotations:");
    int rotationNum = Convert.ToInt32(Console.ReadLine());

    string encrypt = Encrypt(str, rotationNum);
    //print text of user content
    //print final encryption
    Console.WriteLine($"The sentence you inputed is: {str}");
    Console.WriteLine($"The encrypted sentence is now: {encrypt}");
}


static string Encrypt(string stringToEncrypt, int rotation)
{
    string encodedText = "";
    foreach (char c in stringToEncrypt) //for each char in string
    {
        //check if char is a letter
        {
            if (!char.IsLetter(c)) //if non letter then no rotation
            {
                encodedText += c;
            }
            else
            {
                int encodedChar = c + rotation; // link char to string

                //check if char is upper or lower case
                //reset if we reach z or Z
                if (char.IsLower(c))
                {
                    if (encodedChar > 'z')
                    {
                        // go to start of abcs
                        encodedChar -= 26;
                    }
                }
                else if (char.IsUpper(c))
                {
                    if (encodedChar > 'Z')
                    {  // go to start of abcs
                        encodedChar -= 26;
                    }
                }
                encodedText += (char)encodedChar;
            }
        }
      
    }
    return encodedText;
}
//task_7();
void task_7()
{
    //Print text for the user to input string
    Console.WriteLine("Enter a string you wish to decrypt:");
    string str = Console.ReadLine();
    //print test for user to enter itterations
    Console.WriteLine("Enter number of rotations:");
    int rotationNum = Convert.ToInt32(Console.ReadLine());

    string decrypt = Decrypt(str, rotationNum);
    //print text of user content
    //print final decryption
    Console.WriteLine($"The sentence you inputted is: {str}");
    Console.WriteLine($"The decrypted sentence is now: {decrypt}");
}


static string Decrypt(string stringToDecrypt, int rotation)
{
    string decodedText = "";
    foreach (char c in stringToDecrypt) //for each char in string
    {
        //check if char is a letter
        {
            if (!char.IsLetter(c))
            {
                decodedText += c;
            }
            else
            {
                int decodedChar = c - rotation;

                //check upper and lower case
                //reset to z or Z when char is a or A
                if (!char.IsLower(c))
                {
                    if (decodedChar < 'a')
                    {
                        // Go back to z
                        decodedChar += 26;
                    }
                }
                else if (char.IsUpper(c))
                {
                    if (decodedChar > 'A')
                    {
                        // go back to Z
                        decodedChar += 26;
                    }
                }
                decodedText += (char)decodedChar;
            }
        }
        return decodedText;
    }
}

    mainMenu();
    getMainMenuChoice();

    void mainMenu()
    {   //Menu text
        Console.WriteLine("Main Menu");
        Console.WriteLine("Select an option ");
        Console.WriteLine("1 - encrypt text");
        Console.WriteLine("2 - decrypt text");
        Console.WriteLine("3 - End");

    }

    static void getMainMenuChoice()
    {
        try
        {
            //Users choice from menu
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                //Print text for the user to input string
                Console.WriteLine("Enter a string:");
                string str = Console.ReadLine();
                //print test for user to enter itterations
                Console.WriteLine("Enter number of rotations:");
                int rotationNum = Convert.ToInt32(Console.ReadLine());

                string encrypt = Encrypt(str, rotationNum);
                //print text of user content
                //print final encryption
                Console.WriteLine($"The sentence you inputed is: {str}");
                Console.WriteLine($"The encrypted sentence is now: {encrypt}");
            }

            if (choice == 2)
            {
                //Print text for the user to input string
                Console.WriteLine("Enter a string you wish to decrypt:");
                string str = Console.ReadLine();
                //print test for user to enter itterations
                Console.WriteLine("Enter number of rotations:");
                int rotationNum = Convert.ToInt32(Console.ReadLine());

                string decrypt = Decrypt(str, rotationNum);
                //print text of user content
                //print final decryption
                Console.WriteLine($"The sentence you inputted is: {str}");
                Console.WriteLine($"The decrypted sentence is now: {decrypt}");
            }

            if (choice == 3)
            {
                Console.WriteLine("You chose to end program");
                Environment.Exit(0);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error. {ex.Message}");
        }
    }

    CA();
    static void CA()
    {
        int option = 0;
        double radius = 0;
        double height = 0;
        double volumeOfCylinder = 0;
        do
        {
            // Get user option
            Console.WriteLine("1. Enter radius to find area of a circle");
            Console.WriteLine("0. Exit application");
            Console.WriteLine("Enter an option:");
            option = Convert.ToInt32(Console.ReadLine());
            // check option
            switch (option)
            {
                case 0:
                    Console.WriteLine("Goodbye");
                    break;
                case 1:
                    Console.WriteLine("Enter radius:");
                    radius = Convert.ToDouble(Console.ReadLine());
                    double circleArea = CircleArea(radius);
                    Console.WriteLine($"Area of the cylinder is {circleArea} ");
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
            Console.WriteLine();
        } while (option != 0);
    }

    static double CircleArea(double radius)
    {
        // calc area of circle
        double area = Math.PI * Math.Pow(radius, 2);
        // return area of circle
        return area;
    }

