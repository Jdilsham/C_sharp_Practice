using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal class TextEditor
    {
        private ITextFormatter _textFormatter;

        public void SetFormatter(ITextFormatter formatter)
        {
            _textFormatter = formatter;
        }

        public void PublicText(string text)
        {
            if(_textFormatter != null)
            {
                string result = _textFormatter.TextFormat(text);
                Console.Write(result);
            }
            else
            {
                Console.WriteLine("Set the Formatter");
            }
        }
    }
}
