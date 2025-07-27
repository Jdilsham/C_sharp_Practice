using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy
{
    public class TextEditor 
    {
        private ITextFormatter _textFormatter;

        public void SetFormatter(ITextFormatter formatter)
        {
            _textFormatter = formatter;
        }

        public void PublishText(string text)
        {
            if (_textFormatter != null)
            {
                string result = _textFormatter.TxtFormat(text);
                Console.WriteLine("Formatted Text: " + result);
            }
            else
            {
                Console.WriteLine("No Formatter Set");
            }
        }
    }
}
