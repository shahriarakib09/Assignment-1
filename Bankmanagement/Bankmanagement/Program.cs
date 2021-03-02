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
            Address address = new Address();
            Console.WriteLine(address.GetAddress());
            Console.ReadKey();
        }
    }
}
