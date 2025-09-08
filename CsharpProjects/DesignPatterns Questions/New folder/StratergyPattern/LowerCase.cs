using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StratergyPattern
{
    internal class LowerCase : ITextFormatter
    {
        public string TextFormat(string text)
        {
            return text.ToLower();
        }
    }
}
