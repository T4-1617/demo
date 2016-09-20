using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0920_01
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }
        public bool VIP { get; set; }
    }

    public class Employee : Person
    {
        public string Title { get; set; }
        public decimal Salary { get; set; }

        //Vi är inte nöjda med den nedärvda egenskapen Fullname
        //vi vill göra en egen implementation (dvs egen kod)
        //Vi vill göra en OVERRIDE
        //För att det ska funka, behöver basklassen tillåta det
        //Görs via VIRTUAL
        public override string FullName
        {
            get
            {
                return string.Format("{0}, {1}", LastName, FirstName);
            }
        }

    }

    public abstract class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Detta är en READONLY Property
        //Använda alltid properties istället för metoder (best practice)
        //I de fall det funkar, dvs presentera data
        public virtual string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }

        }

    }
}
