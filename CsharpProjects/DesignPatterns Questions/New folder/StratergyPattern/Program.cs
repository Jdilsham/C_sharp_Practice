using System;
using StratergyPattern;

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        string input = Console.ReadLine();

        editor.SetFormatter(new UpperCase());
        editor.PublicText(input);
    }
}