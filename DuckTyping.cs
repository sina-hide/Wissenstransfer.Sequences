using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Sequences.Helpers;

namespace Sequences
{
    [Run(8)]
    public class DuckTyping : IEnumerable<int>
    {
        public DuckTyping()
        {
            foreach (var item in (IEnumerable<int>) this)
                Console.WriteLine($"  {item}");
        }

        private readonly IEnumerable<int> _storyPoints = StoryPoints;

        IEnumerator<int> IEnumerable<int>.GetEnumerator() =>
            _storyPoints.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() =>
            _storyPoints.GetEnumerator();

        public IEnumerator<int> GetEnumerator() =>
            _storyPoints.Reverse().GetEnumerator();
    }
}