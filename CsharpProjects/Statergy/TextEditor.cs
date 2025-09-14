using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statergy
{
    internal class TextEditor
    {
        private ITextFormatter _formatter;

        public void setFormatter(ITextFormatter format)
        {
            _formatter = format;
        }

        public void PublicText(string text)
        {
            if (_formatter != null)
            {
                string result = _formatter.TextFormat(text);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Set Formatter");
            }
        }
    }
}
