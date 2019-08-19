using System.Collections.Generic;
using System.Linq;

namespace Sequences
{
    [Run(7)]
    public class Infinite
    {
        public Infinite() =>
            GetNaturalNumbers()
                .Where(number => number % 2 == 0)
                //.Take(10)
                .Output();

        private IEnumerable<int> GetNaturalNumbers()
        {
            var number = 1;
            while (true)
            {
                yield return number;
                number++;
            }
        }
    }
}