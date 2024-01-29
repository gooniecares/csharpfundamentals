using System;

namespace demoClasses
{
    internal class Person
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }

        internal void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }

       
    }
}