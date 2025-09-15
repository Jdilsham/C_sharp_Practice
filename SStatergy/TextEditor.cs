using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SStatergy
{
    internal class TextEditor
    {
        private ITextFormatter textFormatter;

        public void setFormatter(ITextFormatter formatter)
        {
            textFormatter = formatter;
        }

        public void Publish(string text)
        {
            if(textFormatter != null)
            {
                string result = textFormatter.Format(text);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Set the Formatter");
            }
        }
    }
}
