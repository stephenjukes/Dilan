using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal struct Pair<TFirst, TSecond>
    {
        private TFirst _first;
        private TSecond _second;

        public Pair(TFirst first, TSecond second)
        {
            _first = first;
            _second = second;
        }

        public override string ToString()
        {
            return $"({_first}, {_second})";
        }

        public Pair<TSecond, TFirst> Swap()
        {
            return new Pair<TSecond, TFirst>(_second, _first);
        }
    }
}
