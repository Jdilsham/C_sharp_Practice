using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy
{
    internal class LowerCaseFormatter : ITextFormatter
    {
        public string TxtFormat(string txt)
        {
            return txt.ToLower();
        }
    }
}
