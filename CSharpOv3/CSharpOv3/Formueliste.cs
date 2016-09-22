using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv3
{
    class Formueliste
    {
        List<Person> pers = new List<Person>() { new Person("Arne Aas", 0),
                                                 new Person("Berit Bø", 4300900),
                                                 new Person("Carl Chica", 200000) }; //Chica Chica Boom Boom

        Person[] noobArray = new Person[] { new Person("Arne Aas", 0),
                                             new Person("Berit Bø", 4300900),
                                             new Person("Carl Chica", 200000) };

        public bool registrerNyPerson(Person p)
        {
            try
            {
                pers.Add(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            //try //Ta å sug en jævla svær negerkuk for det her funke itj!!
            //{
            //    Array.Resize<Person>(ref noobArray, noobArray.Length + 1);
            //    noobArray[noobArray.Length - 1] = new Person(p.Navn, p.Formue);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    return false;
            //}

            return true;
        }

        public void print()
        {
            foreach (Person item in pers)
            {
                Console.WriteLine(item.Navn + " " + item.Formue);
            }
        }

        public Person getRikest()
        {
            int x = 0, y = 0;
            for (int i = 0; i < pers.Count; i++)
            {
                if (pers.ElementAt(i).Formue > y)
                    y = pers.ElementAt(i).Formue;
                    x = i;
            }
            return pers.ElementAt(x);
        }
    }
}
