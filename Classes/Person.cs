using System;
using System.Collections.Generic; 

namespace Person_zadanie.Classes
{
    internal class Person
    {
        //Napisz klasę, która tworzy osobę.(id, imie, nazwisko wiek, wzrost, wagę, IQ, lista umiejętności; Wykonaj walidację  danych get i set)
        public string name;
        public string lastName;
        public int age;
        public double date;
        public int matematyka;

        //Konstuktory 
        public Person(string name, string lastName, int age, double date, int matematyka)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Date = date;
            Oceny = matematyka;
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length >= 20 || String.IsNullOrEmpty(value))
                    name = "WRONG INPUT";
                else
                {
                    name = value;
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value.Length >= 20 || String.IsNullOrEmpty(value))
                    lastName = "WRONG INPUT";
                else
                {
                    lastName = value;
                }
            }
        }

        public int? Age
        {
            get { return age; }
            set 
            { 
                if(value >= 155 || value <= 0 || value == null)
                    age = -1;
                else
                {
                    age = (int)value;
                }
            }
        }

        public double? Date
        {
            get { return date; }
            set
            {
                if (value >= 3000 || value <= 0 || value == null)
                    date = -1;
                else
                {
                    date = (double)value;
                }
            }
        }

        public int? Oceny
        {
            get { return matematyka; }
            set
            {
                if(value <= 0 || value >= 7 || value == null)
                {
                    matematyka = -1;
                }
                else
                {
                    matematyka = (int)value;
                }
            }
        }
        //----------------------------------------------------------------------------
        public void Information()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Name\t\t{Name}");
            Console.WriteLine($"LastName\t{LastName}");
            Console.WriteLine($"Age\t\t{Age}");
            Console.WriteLine($"Date\t\t{Date}");
            Console.WriteLine($"Oceny\t\t{Oceny}");
            Console.WriteLine("=======================================");
        }
        public void PrzedstawSie()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine($"Nazywam sie {Name} {LastName}");
            Console.WriteLine("=======================================");
        }
    }
}
