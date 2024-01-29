using demoClasses.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var ben = new Person();
            ben.FirstName = "Ben";
            ben.LastName = "Carter";
            ben.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
