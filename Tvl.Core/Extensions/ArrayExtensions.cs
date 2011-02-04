﻿namespace Tvl.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;

    public static partial class ArrayExtensions
    {
        public static IList<T> Subarray<T>(this T[] array, int startIndex)
        {
            Contract.Requires<ArgumentNullException>(array != null, "array");
            Contract.Requires<ArgumentOutOfRangeException>(startIndex >= 0);
            Contract.Requires<ArgumentException>(startIndex <= array.Length);

            if (startIndex == 0)
                return array;

            return new ArraySegment<T>(array, startIndex, array.Length - startIndex);
        }

        public static IList<T> Subarray<T>(this T[] array, int startIndex, int count)
        {
            Contract.Requires<ArgumentNullException>(array != null, "array");
            Contract.Requires<ArgumentOutOfRangeException>(startIndex >= 0);
            Contract.Requires<ArgumentOutOfRangeException>(count >= 0);
            Contract.Requires<ArgumentException>(startIndex <= array.Length);
            Contract.Requires<ArgumentException>(checked(startIndex + count) <= array.Length);

            if (startIndex == 0 && count == array.Length)
                return array;

            return new ArraySegment<T>(array, startIndex, count);
        }

        public static T[] CloneArray<T>(this T[] array)
        {
            Contract.Requires<ArgumentNullException>(array != null, "array");

            return (T[])array.Clone();
        }
    }
}
