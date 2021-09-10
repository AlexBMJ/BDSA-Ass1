using System;
using System.Collections.Generic;
using Assignment1;
namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var gc = new GreaterCountTypeConstraint();
            var platypus = new Platypus(4);
            var platypus_list = new List<Platypus>() {new Platypus(5), new Platypus(2)};
            Console.WriteLine(gc.GreaterCount<Platypus, Animal>(platypus_list, platypus));
        }
    }
}
