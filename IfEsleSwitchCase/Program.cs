using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfEsleSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 14;

            if(hour > 0 && hour < 12) 
            {
                Console.WriteLine("Its Moring");
            }
            else if(hour > 0 && hour < 12)
            {
                Console.WriteLine("Its AfterNoon");
            }
            else
            {
                Console.WriteLine("It's Evening");
            }
            
        }
    }
}
