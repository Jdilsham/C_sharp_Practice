using System;
using SStatergy;

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor textEditor = new TextEditor();

        Console.WriteLine("Enter Text :");
        string text = Console.ReadLine();

        textEditor.setFormatter(new UpperCase());
        textEditor.Publish(text);

        textEditor.setFormatter(new LowerCase());
        textEditor.Publish(text);
    }
}