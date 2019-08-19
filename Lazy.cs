using System;
using System.Collections.Generic;

namespace Sequences
{
    [Run(2)]
    public class Lazy
    {
        public Lazy()
        {
            var fibonacciNumbers = GetFibonacciNumbers(13);
            foreach (var item in fibonacciNumbers)
                Console.WriteLine($"  {item}");
        }

        private IEnumerable<int> GetFibonacciNumbers(int limit)
        {
            var current = 1;
            var next = 2;

            while (current <= limit)
            {
                yield return current;
                (current, next) = (next, current + next);
            }
        }
    }
}