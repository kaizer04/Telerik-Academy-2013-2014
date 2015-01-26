namespace IEnumerableSumProductMinMaxAverage
{
    using System;
    using System.Collections.Generic;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> enumcollection)
        {
            bool emptyCollection = true;
            
            dynamic sum = 0;
            
            foreach (var item in enumcollection)
            {
                emptyCollection = false;
                sum += item;
            }

            if (emptyCollection)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)sum;
        }

        public static T Product<T>(this IEnumerable<T> enumcollection)
        {
            bool emptyCollection = true;
            
            dynamic product = 1;
            
            foreach (var item in enumcollection)
            {
                emptyCollection = false;
                product *= item;
            }
            
            if (emptyCollection)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)product;
        }

        public static T Average<T>(this IEnumerable<T> enumcollection)
        {
            dynamic sum = 0;
            
            dynamic count = 0;
            
            foreach (var item in enumcollection)
            {
                count++;
                sum += item;
            }
            
            if (count == 0)
            {
                throw new ArgumentException("Empty Collection");
            }
            
            return (T)(sum / count);
        }

        public static T GetMin<T>(this IEnumerable<T> enumcollection)
            where T : IComparable<T>
        {
            IEnumerator<T> enumerator = enumcollection.GetEnumerator();
            
            enumerator.MoveNext();
            
            T element = enumerator.Current;
            
            foreach (var i in enumcollection)
            {
                if (i.CompareTo(element) < 0)
                {
                    element = i;
                }
            }
           
            return element;
        }

        public static T GetMax<T>(this IEnumerable<T> enumcollection)
            where T : IComparable<T>
        {
            IEnumerator<T> enumerator = enumcollection.GetEnumerator();
            
            enumerator.MoveNext();
            
            T element = enumerator.Current;
            
            foreach (var i in enumcollection)
            {
                if (i.CompareTo(element) > 0)
                {
                    element = i;
                }
            }
            
            return element;
        }
    }
}