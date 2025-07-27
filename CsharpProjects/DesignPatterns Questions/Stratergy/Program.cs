using Stratergy;
using System;

class Program
{
    static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();
        string input = Console.ReadLine();

        editor.SetFormatter(new UpperCaseFormatter());
        editor.PublishText(input);

        editor.SetFormatter(new LowerCaseFormatter());
        editor.PublishText(input);
    }
}