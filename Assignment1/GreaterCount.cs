using System;
using System.Collections.Generic;

namespace Assignment1 {
    public class Animal : IComparable<Animal> {
        private int kids;

        public Animal(int kids) {
            this.kids = kids;
        }
        public int CompareTo(Animal that) {
            if (this.kids < that.kids) return -1;
            if (this.kids == that.kids) return 0;
            return 1;
        }
    }

    public class Platypus : Animal {
        public Platypus(int kids) : base(kids) { }
    }

    public class GreaterCountTypeConstraint {
        public int GreaterCount<T, U>(IEnumerable<T> items, T x)
            where T : U
            where U : IComparable<U> {
            var greaterCount = 0;
            foreach (T t in items)
                if (t.CompareTo(x) > 0)
                    greaterCount++;
            return greaterCount;
        }
    }
}