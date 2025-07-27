using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy2
{
    public class UpperCase : ITextFormatter
    {
        public string txtFormat(string txt)
        {
            return txt.ToUpper();
        }
    }
}
