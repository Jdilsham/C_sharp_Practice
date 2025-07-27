using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy2
{
    public class TextEditor
    {
        private ITextFormatter formatter;

        public void SetFormatter(ITextFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void PublishText(string text)
        {
            if (formatter != null)
            {
                string result = formatter.txtFormat(text);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("No Formatter Set!");
            }
        }
    }
}
