/*

int numericValue;
bool validNumber = false;
string? readResult;
Console.WriteLine("Enter a number between 5 and 10");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if (validNumber)
        {
            if (numericValue >= 5 && numericValue <= 10)
            {
                Console.WriteLine($"Your input value ({numericValue}) has been accepted.");
                break;
            }
            else
            {
                Console.WriteLine($"Yo entered {readResult}. Please enter a number between 5 and 10.");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you etered an invalid number, please try again");
        }
    }
} while (true);

*/

/*

string? readResult;
string formatResult;
do
{
    Console.WriteLine("Enter your role name (Administrator, Manger, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        formatResult = readResult.Trim().ToLower();
        if (formatResult == "administrator" || formatResult == "manager" || formatResult == "user")
        {
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
            break;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{readResult}\" is not valid.");
        }
    }
} while (true);

*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;

for (int idx = 0; idx < myStrings.Length; idx++)
{
    string myString = myStrings[idx];
    periodLocation = myString.IndexOf(".");

    string delDot;

    while (periodLocation != -1)
    {
        delDot = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(delDot);
    }

    delDot = myString.Trim();
    Console.WriteLine(delDot);
}
