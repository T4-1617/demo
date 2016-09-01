using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSept1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            Console.WriteLine(s);
            Console.WriteLine(s.Length);

            Console.WriteLine(s.Trim());
            Console.WriteLine(s.Trim().Length);

            for (int i = 0; i < 5; i++)
            {
                //i++ är samma sak som i=i+1
                //i kallas för en räknare
                Console.WriteLine("Value of i=" + i.ToString());
            }

            //Skriv ut varje bokstav, en i taget
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }

            //Detta är samma sak som ovanför
            foreach (char item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(s.PadLeft(20));

            Console.WriteLine(s.Replace('a','x'));
            Console.WriteLine(s.Replace(' ', '_'));

            Console.WriteLine(s.Substring(5));

            Console.WriteLine(s.Substring(s.IndexOf(' ')+1));


        }
      
    }
}
