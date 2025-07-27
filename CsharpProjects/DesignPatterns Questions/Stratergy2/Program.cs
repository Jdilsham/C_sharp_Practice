using System;
using Stratergy2;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        string input = Console.ReadLine();

        editor.SetFormatter(new UpperCase());
        editor.PublishText(input);

        editor.SetFormatter(new LowerCase());
        editor.PublishText(input);
    }

}