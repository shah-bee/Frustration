using System;
using System.Collections.Generic;
using System.Text;

namespace Frustration
{
    public struct Nullable<T> where T : struct
    {
        private readonly T value;
        private readonly bool hasValue;
        public Nullable(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        public bool HasValue => this.hasValue;

        public T Value
        {
            get
            {
                if (!hasValue)
                {
                    throw new InvalidOperationException();
                }
                return value;
            }
        }

        public object GetHash => this.GetHashCode();
    }
}
