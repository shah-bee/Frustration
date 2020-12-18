using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Frustration
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> ExtendWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {

            foreach (T value in source)
            {
                if (predicate(value)) yield return value;
            }
        }

    }
}
