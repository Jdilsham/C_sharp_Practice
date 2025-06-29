﻿using System;
using System.Globalization;

//1************************************************************

/*
Console.WriteLine("Enter numbers separated by '-' :");
string arr = Console.ReadLine();
string[] parts = arr.Split('-');
List<int> numbers = new List<int>();
foreach (string part in parts)
{
    numbers.Add(int.Parse(part));
}

bool isConsecative = true;

for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] != numbers[i - 1] + 1 && numbers[i] != numbers[i - 1] - 1)
    {
        isConsecative = false;
        break;
    }
}

if (isConsecative)
{
    Console.WriteLine("Consecative");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Not Consecative");
}
*/

//2************************************************************

/*
Console.WriteLine("Enter few Numbers: ");
string input = Console.ReadLine();

if (input == "")
{
    Console.WriteLine("Error!");
    return;
}

string[] parts = input.Split('-');
List<int> numbers = new List<int>();
foreach (string part in parts)
{
    numbers.Add(int.Parse(part));
}

bool duplicate = false;

for (int i = 0; i < numbers.Count; i++)
{
    for (int j = i + 1; j < numbers.Count; j++)
    {
        if (numbers[j] == numbers[i])
        {
            duplicate = true;
            break;
        }
    }
    if (duplicate)
    {
        break;
    }
}

if (duplicate)
{
    Console.WriteLine("Has Duplicate");
}
else
{
    Console.WriteLine("No Duplicate");
}
*/


//3************************************************************

/*

Console.WriteLine("Enter fe Words: ");
string input = Console.ReadLine();

if (input == null || input == "")
{
    Console.WriteLine("Error");
    return;
}

string[] parts = input.Split(' ');

string camelCaseName = "";

foreach (string part in parts)
{
    if (part == "")
    {
        continue;
    }

    string lower = part.ToLower();
    string capitalized = char.ToUpper(lower[0]) + lower.Substring(1);
    camelCaseName += capitalized;
}

if (camelCaseName == "")
{
    Console.WriteLine("Error!");
}
else
{
    Console.WriteLine(camelCaseName);
    Console.ReadKey();
}
*/


//4************************************************************

/*
Console.WriteLine("Enter word: ");
string input = Console.ReadLine();

if (input == null || input == "")
{
    Console.WriteLine("Null or Empty");
    return;
}

int vowelCount = 0;
string lowercase = input.ToLower();

foreach (char c in lowercase) {
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'o' || c == 'u') {
        vowelCount++;
    }
}

Console.WriteLine("No of Vowels: " + vowelCount);
Console.ReadKey();

*/


//5*************************************************************

/*

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

char[] charArray = name.ToCharArray();

Array.Reverse(charArray);

string Reversedname = new string(charArray);

Console.WriteLine("Reversed Name: " + Reversedname);
Console.ReadLine();

*/


//6************************************************************
/*
Console.WriteLine("Enter 5 Numbers: ");

List<int> numbers = new List<int>(5);

while (numbers.Count < 5)
{
    Console.Write($"Enter Number {numbers.Count + 1}: ");

    string input = Console.ReadLine();
    int num;
    try
    {
        num = Convert.ToInt32(input);
    }
    catch
    {
        Console.WriteLine("Please enter valid number.");
        continue;
    }

    if (numbers.Contains(num))
    {
        Console.WriteLine("Number is already enterd, enter anothor number");
    }
    else
    {
        numbers.Add(num);
    }

}

numbers.Sort();
Console.WriteLine("Sorted Numbers: " + string.Join(", ", numbers));
*/

//7*****************************************************************
/*
List<int> list = new List<int>();
string input;
Console.WriteLine("Enter integer one by one, Type 'Quit' to exit.");
while (true)
{
    input = Console.ReadLine();
    if (input.Equals("Quit"))
    {
        break;
    }

    int number = int.Parse(input);
    if (!list.Contains(number))
    {
        list.Add(number);
    }

}

foreach (int item in list)
    {
        Console.WriteLine(item);
    }
*/


Console.WriteLine("Enter Numbers separated by comma: ");
string input = Console.ReadLine();

while (true)
{
    if (input == null || input.Trim() == "")
    {
        Console.WriteLine("Invalid, Try again");
        continue;
    }

    string[] parts = input.Split(',');
    if (parts.Length < 5)
    {
        Console.WriteLine("Invalid, Try again");
    }

    List<int> numbers = new List<int>();
    bool valid = true;

    foreach (string part in parts)
    {
        try
        {
            int number = int.Parse(part.Trim());
            numbers.Add(number);
        }
        catch (System.Exception)
        {

            valid = false;
            break;
        }
    }
}

