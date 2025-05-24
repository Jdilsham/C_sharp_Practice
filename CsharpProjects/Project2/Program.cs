/*Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
*/

/*
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
*/
/*


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/

//int saleAmount = 101;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");
//Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/*
Random random = new Random();
int rand = random.Next(1, 3);
//Console.WriteLine(rand);
Console.WriteLine(rand == 1 ? "head" : "tail");
*/

/*
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }

    else
    {
        Console.WriteLine("Welcome, Admin User.");
    }

}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Welcome, Super Manager User.");
    }
    else
    {
        Console.WriteLine("Welcome, Manager user.");
    }
}
else {
    Console.WriteLine("Error!");
}
*/

/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total =0;
bool found = false;

foreach (int number in numbers)
{
    
    total += number;

    if (number == 42)
    {

        found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");

*/

/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
*/


string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();