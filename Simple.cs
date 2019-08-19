using System;
using System.Collections.Generic;

namespace Sequences
{
    [Run(1)]
    public class Simple
    {
        public Simple()
        {
            IEnumerable<int> sequence = Helpers.StoryPoints;
            sequence.Output();
        }
    }
}