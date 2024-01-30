using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(var i = 1; i <= 10; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //    Console.WriteLine(i);
            //    }
            //}

            //var i = 0;
            //while(i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //    i++;

            //}

            // no counter means this loops is gonna go on forever
            // It will keep looping because it's never terminated.
            //while (true)
            //{
            //    Console.WriteLine("Type Your Name: ");
            //    var input = Console.ReadLine();
            //}

            // no counter means this loops is gonna go on forever
            // It will keep looping because it's never terminated.
            //while (true)
            //{
            //    Console.WriteLine("Type Your Name: ");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }

            //    Console.WriteLine("@Echo: " + input);


            //}


            // This program is the same above just a different way to achieve it.

            while (true)
            {
                Console.WriteLine("Type Your Name: ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;

                


            }
        }
    }
}
