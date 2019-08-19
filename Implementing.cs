using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sequences
{
    [Run(6)]
    public class Implementing : IEnumerable<char>
    {
        public Implementing()
        {
            foreach (var c in this)
                Console.Write(c);
            Console.WriteLine();
        }

        private readonly List<string> _buffer =
            new List<string>() {"Hello", " ", "World!"};
        public IEnumerator<char> GetEnumerator() =>
            GetSequence().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private IEnumerable<char> GetSequence() =>
            _buffer.Aggregate(
                Enumerable.Empty<char>(), Enumerable.Concat);
    }
}