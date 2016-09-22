using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv3
{
    class Program
    {
        static void Main(string[] args)
        {

            Formueliste lst = new Formueliste();

            //Person p = new Person("Joachim FS", 10000);

            //lst.registrerNyPerson(p);

            lst.print();

            Person rikest = lst.getRikest();

            Console.WriteLine("{0} har en formue på {1}", rikest.Navn, rikest.Formue);

            Console.ReadKey();
        }
    }
}
