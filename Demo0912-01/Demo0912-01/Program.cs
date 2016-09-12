using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0912_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testar att skapa ett objekt av klassen Car

            Car c = new Car(); //Instansiera, kopiera från fil till minne

            c.Color = "Red";

            Console.WriteLine("Bilens färg är {0}", c.Color);

            //Ny test
            Car d;

            d = c;

            d.Color = "Blue";

            Console.WriteLine("Bilens färg är {0}", c.Color);
            Console.WriteLine("Bilens färg är {0}", d.Color);

            //Value type
            int i=10;
            int j;
            j = i;
            j = 20;

            Console.WriteLine("i={0} och j={1}",i,j);

            //Testar Customer
            Customer MyCustomer = new Customer();
            MyCustomer.FirstName = "Kalle";
            MyCustomer.LastName = "Anka";

            Console.WriteLine(MyCustomer.FullName());

        }
    }

    public class Car
    {
        public string RegistrationNumber { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
    }
}
