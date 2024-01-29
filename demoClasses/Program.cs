using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ben = new Person();
            ben.FirstName = "Ben";
            ben.LastName = "Carter";
            ben.Introduce();
        }
    }
}
