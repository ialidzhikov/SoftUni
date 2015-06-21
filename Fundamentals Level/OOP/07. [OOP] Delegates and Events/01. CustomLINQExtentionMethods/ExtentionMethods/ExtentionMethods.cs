using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtentionMethods
{
    public static class ExtentionMethods
    {
        #region Methods

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> elementsToReturn = new List<T>();
            foreach (T element in collection)
            {
                if (!predicate(element))
                {
                    elementsToReturn.Add(element);
                }
            }
            return elementsToReturn;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
            Func<TSource, TSelector> function) where TSelector : IComparable
        {
            TSelector maxElement = function(collection.First());
            foreach (TSource element in collection)
            {
                if (maxElement.CompareTo(function(element)) < 0)
                {
                    maxElement = function(element);
                }
            }
            return maxElement;
        }

        #endregion
    }
}
