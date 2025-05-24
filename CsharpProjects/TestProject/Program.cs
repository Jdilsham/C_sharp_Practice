/*Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine(dice.Next(1, 7));

//Random dice = new Random();

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

/*
Console.WriteLine("Day 02");
Console.WriteLine("Arrays");

string[] Names = new string[3];
Names[0] = "Janitha";
Names[1] = "Dilsham";
Names[2] = "Wanni Arachchi";

Console.Write(Names[0]);
Console.Write(" " + Names[1]);
Console.Write(" " + Names[2]);
*/


/*string[] arr = [ "Janitha", "Dilsham", "Wanni", "Arachchi" ];
//Console.WriteLine(arr[0]);

foreach (string name in arr)
{ 
    Console.WriteLine(name);
}
*/

/*
string[] Arr = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
foreach (string code in Arr)
{
    if (code.StartsWith("B"))
    { 
        Console.WriteLine("" + code);
    }
}
*/


Console.WriteLine("Random order Numbers");

/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (string orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

/*
Console.WriteLine("Count a letter");

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] massage = originalMessage.ToCharArray();

int letterCount = 0;

foreach (char c in massage)
{
    if (c == 'o')
    {
        letterCount++;
    }
}

Console.WriteLine("Count of 'o' is: " + letterCount);
*/


