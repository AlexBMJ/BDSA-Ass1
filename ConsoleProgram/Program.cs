using System;
using System.Collections.Generic;
using Assignment1;
namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = (int i) => i % 2 == 0;

            var test = Iterators.Filter<int>(new int[]{1, 2, 3, 4, 5}, even);
            foreach(var item in test) {
                Console.WriteLine(item);
            }
        }
    }
}
