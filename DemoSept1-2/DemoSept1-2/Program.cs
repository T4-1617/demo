using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSept1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter something:");
            string s = Console.ReadLine();

            if (s.Length > 5)
            {
                Console.WriteLine("Wow, long name");
            }

            //Obs, break är viktigt
            switch (s.Length)
            {
                case 5:
                    Console.WriteLine("5 chars in your name");
                    break;

                case 6:
                    Console.WriteLine("6 chars in your name");
                    break;
              
                default:
                    Console.WriteLine("Don't bother");
                    break;
            }

            //AND = &&
            //OR = ||
            if (s.Length > 5 && s.Length < 10)
            {
                //6-9
                Console.WriteLine("Your name has a sweetspot of 6-9 chars!");
            }

            //Testa något är == tecken
            if (s.Length == 7)
            {
                Console.WriteLine("Lucky 7");
            }
        }
    }
}
