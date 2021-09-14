using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1 {
    public class Animal : IComparable<Animal> {
        private readonly int kids;

        protected Animal(int kids) {
            this.kids = kids;
        }
        public int CompareTo(Animal that) {
            if (this.kids < that.kids) return -1;
            return this.kids == that.kids ? 0 : 1;
        }
    }

    public class Platypus : Animal {
        public Platypus(int kids) : base(kids) { }
    }

    public class GreaterCountTypeConstraint {
        public static int GreaterCount<T, U>(IEnumerable<T> items, T x)
            where T : U
            where U : IComparable<U> {
            return items.Count(t => t.CompareTo(x) > 0);
        }
    }
}