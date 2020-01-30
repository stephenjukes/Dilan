using System;
using System.Collections.Generic;
using System.Text;

namespace Dilan
{
    public struct Pair<Type1, Type2>
    {
        private Type1 First;
        private Type2 Second;

        public Pair(Type1 first, Type2 second)
        {
            this.First = first;
            this.Second = second;
        }

        public override string ToString()
        {
            return $"( {First}, {Second} )";
        }
    }
}
