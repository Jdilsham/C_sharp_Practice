using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statergy
{
    internal class UpperCase : ITextFormatter
    {
        public string TextFormat(string text)
        {
            return text.ToUpper();
        }
    }
}
