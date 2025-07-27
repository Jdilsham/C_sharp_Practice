using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratergy
{
    public class UpperCaseFormatter : ITextFormatter
    {
        public string TexFormat(string txt)
        {
            return txt.ToUpper();
        } 
            
    }
}
