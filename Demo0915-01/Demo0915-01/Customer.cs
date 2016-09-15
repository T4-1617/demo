using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo0915_01
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Detta gör att en sträng visas när objektet efterfrågas vid utskrift
        //exempelvis i en listbox
        //public override string ToString()
        //{
        //    return string.Format("{0} {1}", FirstName,LastName);
        //}

        //Detta funkar inte med DisplayMemeber eftersom det är en METOD
        //DisplyMember KRÄVER en PROPERTY
        //public string FullName()
        //{
        //    return string.Format("{0} {1}", FirstName, LastName);
        //}



        //Detta är en READONLY PROPERTY
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName);
            }

        }

    }
}
