using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClasses
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var ben = new Person();
            ben.FirstName = "Benjamin";
            ben.LastName = "Carter";
            ben.Introduce();
        }
    }
}
