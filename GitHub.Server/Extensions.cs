using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Server
{
    public static class Extensions
    {
        public static string ToHeader(this String value)
        {
            string output = null;
            foreach (char c in value)
            {
                output += $"{c} ";
            }
            return output.ToUpper();
        }
    }
}
