using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The goal is to show each character on each line.
            // Both for loops are doing the same thing.

            //var name = "John Smith";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //foreach(var character in name)
            //{
            //    Console.WriteLine(character);
            //}

            var numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
