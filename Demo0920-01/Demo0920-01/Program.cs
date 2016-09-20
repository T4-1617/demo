using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0920_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p ;
            p = new Customer();
            p.FirstName = "Kalle"; //2 properties

            Customer c;
            c = (Customer)p;
            c.CustomerId = 100; //4 properties
            c.FirstName = "Arne";
            c.LastName = "Anka";

            Console.WriteLine(p.FirstName);

            Console.WriteLine(p.FullName);

            Employee emp;
            p = new Employee();
            p.FirstName = "Musse";
            p.LastName = "Pigg";

            emp = (Employee)p;
            Console.WriteLine(emp.FullName);
            Console.WriteLine(p.FullName);
            Console.WriteLine(c.FullName);
        }
    }
}
