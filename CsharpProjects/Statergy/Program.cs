using System;
using Statergy;

public class Program
{
    public static void Main(string[] args) 
    {
        TextEditor editor = new TextEditor();

        Console.WriteLine("Enter data");
        string Text = Console.ReadLine();

        editor.setFormatter(new UpperCase());
        editor.PublicText(Text);

        editor.setFormatter(new LowerCase());
        editor.PublicText(Text);
    }
}