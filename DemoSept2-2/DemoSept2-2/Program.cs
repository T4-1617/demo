using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSept2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slumpmässighet
            Random r = new Random();

            for (int i = 0; i < 20; i++)
            {
                //Ger slumptal från 0 till 9
                Console.WriteLine(r.Next(0,10));
            }
        }
    }
}
