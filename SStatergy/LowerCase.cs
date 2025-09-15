using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SStatergy
{
    internal class LowerCase : ITextFormatter
    {
        public string Format(string text)
        {
            return text.ToLower();
        }
    }
}
