using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SStatergy
{
    internal class UpperCase : ITextFormatter
    {
        public string Format(string text)
        {
            return text.ToUpper();
        }
    }
}
