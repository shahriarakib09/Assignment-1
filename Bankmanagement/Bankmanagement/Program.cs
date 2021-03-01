using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankmanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("21", "14", "Dhaka", "Bangladesh");
            Console.WriteLine(address.GetAddress());
            Console.ReadKey();
        }
    }
}
