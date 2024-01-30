using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfEsleSwitchCase
{
    
}

namespace IfEsleSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = 14;

            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn And It's A beautiful season");
                break;

                case Season.Summer:
                    Console.WriteLine("It's Summer perfect time to go to beach if no hurricanes.");
                break;

                case Season.Winter:
                    Console.WriteLine("We have winter promotions");
                break;

                default:
                    Console.WriteLine("I don't understand whats the season");
                break;

            }

            

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
