using System;
using System.Collections.Generic;
using System.Text;

namespace Frustration
{
    public class TypesDefault<T> where T: new()
    {
        private readonly static int value;
        static TypesDefault()
        {
            Console.WriteLine("Static Constructor, {0}", typeof(T));
        }

        public static void Display() {
            Console.WriteLine("Value of T, {0}", value.GetType());
        }
    }
}
