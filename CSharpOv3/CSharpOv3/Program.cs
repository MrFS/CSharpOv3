﻿using System;
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

            Person p = new Person("Joachim FS", 1000000);

            lst.registrerNyPerson(p);

            lst.print();

            //Console.WriteLine(lst.getRikest());

            Console.ReadKey();
        }
    }
}