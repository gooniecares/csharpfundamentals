using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;
            var c = 5;

            //Console.WriteLine(a + b);                             //Yiekds 13
            //Console.WriteLine((float)a / (float)b);               //Yeikds 3.333333
            //Console.WriteLine(a + b + c);                         //Yeilds 18
            //Console.WriteLine(a + b * c);                         //Yeilds 25

            //Console.WriteLine(a > b);                             //Yeilds true
            //Console.WriteLine(a < b);                             //Yeilds false
            //Console.WriteLine(a == b);                            //Yeilds false
            //Console.WriteLine(!(a != b));                         //Yeilds false  2 negatives equal one a positive

            //Console.WriteLine(c < b && c > a);                    //Yeilds false
            //Console.WriteLine(c > b && c < a);                    //Yeilds true
            //Console.WriteLine(c > b && c == a);                   //Yeilds false  true and false results to false
            //Console.WriteLine(c > b || c == a);                   //Yeilds true
            //Console.WriteLine(c < b || c == a);                   //Yeilds false
            Console.WriteLine(!(c < b) || c == a);                  //Yeilds true


        }
    }
}
