using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Person_zadanie.Classes
{
    internal class Live
    {
        public List<Person> Persons = new List<Person>();

        public void AddPerson()
        {
            try
            {
                Console.WriteLine("Imie");
                string name = Console.ReadLine();
                Console.WriteLine("Nazwisko");
                string lastName = Console.ReadLine();
                Console.WriteLine("Lata");
                int age = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Data");
                double date = Int64.Parse(Console.ReadLine());
                Console.WriteLine("Oceny z matematyki");
                int matematyka = Int32.Parse(Console.ReadLine());
                Person person = new Person(name, lastName, age, date, matematyka);
            } catch (Exception error)
            {
                Console.WriteLine(error);
            }
        }

        public void AllUsersInformation()
        {
            foreach (Person person in Persons)
            {
                person.Information();
            }
        }

        public static void MediumOceny(List<Person> lista)
        {
            double suma = 0;
            foreach (Person person in lista)
            {
                suma += person.matematyka;
            }
            Console.WriteLine($"MediumOceny \t {suma / lista.Count}");
        }

        public void MediumOceny()
        {
            Console.Clear();
            double suma = 0;
            foreach (Person person in Persons)
            {
                suma += person.matematyka;
            }
            Console.WriteLine($"MediumOceny \t {suma / Persons.Count}");

        }
        public void AllUsersPrzedstawSie()
        {
            foreach (Person person in Persons)
            {
                person.PrzedstawSie();
            }
        }
    }
}
