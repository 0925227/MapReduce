using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReduce
{
    static class MapReduce
    {
        public static IEnumerable<T2> Map<T1, T2>(IEnumerable<T1> collection, Func<T1, T2> transformation)
        {
            T2[] result = new T2[collection.Count()];
            for (int i = 0; i < collection.Count(); i++)
            {
                result[i] = transformation(collection.ElementAt(i));
            } 
            return result;
        }

        public static IEnumerable<T> Where<T>(IEnumerable<T> collection, Func<T, bool> condition)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < collection.Count(); i++)
            {
                if (condition(collection.ElementAt(i)))
                    result.Add(collection.ElementAt(i));
            }
            return result;
        }

        public static T2 Reduce<T1, T2>(IEnumerable<T1> collection, T2 init, Func<T2, T1, T2> operation)
        {
            T2 result = init;
            for (int i = 0; i < collection.Count(); i++)
            {
                result = operation(result, collection.ElementAt(i));
            }
            return result;
        }
    }
}
