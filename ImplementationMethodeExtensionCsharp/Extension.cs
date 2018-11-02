using System;
using System.Collections.Generic;


namespace ImplementationMethodeExtensionCsharp
{
    public static class Extension
    {
        public static IEnumerable<T> Filtrer<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var resultat = new List<T>();
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    resultat.Add(item);
                }
            }

            return resultat;
        }
    }
}
