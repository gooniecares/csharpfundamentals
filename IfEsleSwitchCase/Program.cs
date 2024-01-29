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

            

            bool isGoldCustomer = false;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);

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
