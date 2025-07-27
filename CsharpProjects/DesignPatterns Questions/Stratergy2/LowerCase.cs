using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy2
{
    public class LowerCase : ITextFormatter
    {
        public string txtFormat(string txt)
        {
            return txt.ToLower();
        }
    }
}
