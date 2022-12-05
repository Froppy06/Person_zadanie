using Person_zadanie.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Person_zadanie
{
    internal partial class Run
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Uczen 1");
            Person TEST1 = new Person($"Ala", "Alowata", 20, 2007, matematyka: 2);
            TEST1.Information();
            TEST1.PrzedstawSie();

            Console.WriteLine("Uczen 2");
            Person TEST2 = new Person("Patryk", "Młotek", 20, 2003, matematyka: 3);
            TEST2.Information();
            TEST2.PrzedstawSie();

            Console.WriteLine("Uczen 3");
            Person TEST3 = new Person("Ola", "Myszka", 20, 2016, matematyka: 4);
            TEST3.Information();
            TEST3.PrzedstawSie();

            string s = "";
            Console.WriteLine(s.Length);

            Live live = new Live();

            live.Persons.Add(TEST1);
            live.Persons.Add(TEST2);
            live.Persons.Add(TEST3);

            bool programWork = true;
            while (programWork)
            {
                Console.WriteLine("w - live progrma");
                Console.WriteLine("so - Srednia Oceny");
                string inp = Console.ReadLine().ToLower().Trim();
                switch (inp)
                {
                    case "w":
                        Console.Clear();
                        programWork = false;
                        break;
                    case "so":
                        live.MediumOceny();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("There is no such command");
                        break;
                }
            }

            Console.WriteLine("Have a good day !!! and see you !!!");
            Console.ReadKey();
        }
    }
}
