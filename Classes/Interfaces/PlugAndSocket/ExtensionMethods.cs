using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Interfaces
{
    public static class ExtensionMethods
    {
        public static string Name(this object obj)
            => obj.ToString().Split(".").Last();
    }
}
