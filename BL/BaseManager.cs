using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BaseManager
    {

        protected internal string ContentBasePath {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Content"); }
        }
    }
}
