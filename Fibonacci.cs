using System;
using System.Collections.Generic;
using System.Text;

namespace Frustration
{
    public class FibonacciSeries
    {
        public static IEnumerable<int> Fibonacci() {

            int current = 0;
            int next = 1;
             
            while (true) {
                yield return current;
                int oldCurrent = current;
                current = next;
                next = next + oldCurrent;
            }
        }

    }
}
