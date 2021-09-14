using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    public static class Iterators {
        public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items) =>
            items.SelectMany(itemList => itemList ??new List<T>());

        public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate) => items.Where(item => predicate(item));
    }
}
