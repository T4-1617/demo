using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo0920_03b;

namespace Demo0920_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer() { FirstName="Arne", LastName="Anka" };
            Console.WriteLine(c.FirstName);
        }
    }

    
}
