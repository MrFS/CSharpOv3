using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv3
{
    class Person
    {
        public Person(string navn, int formue)
        {
            Navn = navn;
            Formue = formue;
        }
        /* Properties */
        public string Navn
        {
            get;
            private set;
        }

        public int Formue
        {
            get;
            private set;
        }
        public override string ToString()
        {
            return Navn + " " + Formue.ToString();
        }
    }
}
