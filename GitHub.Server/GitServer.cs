using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub.Server
{
    public class GitServer
    {
        public static string Hello()
        {
            return $"Hello Git! Today is {DateTime.Now.ToShortDateString()}";
        }
    }
}
