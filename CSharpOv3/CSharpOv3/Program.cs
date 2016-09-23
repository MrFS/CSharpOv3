using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            Person p = new Person("Joachim FS", 10000);
            Person q = new Person("Slawomir Banach", 5000000);

            lst.registrerNyPerson(p);
            lst.registrerNyPerson(q);

            lst.ToString();

            Person rikest = lst.getRikest();

            Console.WriteLine("{0} har en formue på {1}", rikest.Navn, rikest.Formue);

            lst.Sorter();

            Console.WriteLine("Trykk en tast for å fortsette");

            Console.ReadKey();

            Console.WriteLine("____________________________________________________");


            do
            {
                try
                {

                    do
                    {
                        Console.Write("Skriv navn: ");
                        string x = Console.ReadLine();
                        int y = 0;
                        Console.Write("Skriv Formue: ");
                        if (Int32.TryParse(Console.ReadLine(), out y))
                        {
                            Person u = new Person(x, y);

                            if (lst.registrerNyPerson(u))
                            {
                                Console.WriteLine("Du har registrert en ny person : " + u.ToString());
                            }
                            else
                            {
                                Console.WriteLine("En feil skjedde ved registrering av ny person.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ugyldig Formue");
                        }

                        Console.WriteLine("Registrere ny person? Y/N");

                        
                        if (Console.ReadKey().Key == ConsoleKey.N)
                        {
                            Console.WriteLine("\n");
                            break;
                        }

                    } while (true);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                    if (Debugger.IsAttached)
                        Debug.WriteLine(e.Message);
                }

                Console.WriteLine("____________________________________________________");

                Console.WriteLine("\n" + 
                                  "Printer nå innholdet fra listen/tabellen\n" + 
                                  "Sortering med personen som har størst formue først\n");
                lst.Sorter();

                Console.WriteLine("\n" + 
                                  "Finner den rikeste personen og printer ut vedkommende\n\n" +
                                  lst.getRikest().ToString());


                


            } while (Console.ReadKey().Key != ConsoleKey.Q);
        }
    }
}
