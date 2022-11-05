using System;
using System.Collections.Generic;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Osoba o = new Osoba("Adam", "Adamski");
            Console.WriteLine(o.Imie);
            Console.WriteLine("Osoba:"+o);
            o = new Osoba("Karolina", "Karolewska");
            Osoba o2 = new Osoba("Karolina", "Karolewska");
            Console.WriteLine( o == o2);
            Console.WriteLine(o.Equals(o2));
            Student s = new Student("Karolina", "Karolewska"); ;
            Student s2 = new Student("Karolina", "Karolewska"); ;
            Console.WriteLine(s == s2);
            Console.WriteLine(s.Equals(s2));
            Console.WriteLine(o2.Equals(s2));
            Console.WriteLine(s2.Equals(o2));
            Osoba o3 = (Osoba)s;
            Console.WriteLine(o3.Equals(s2));
            Console.WriteLine("====================");
            Console.WriteLine(porownaj(o2, s2));
            Console.WriteLine(porownaj(s2, o2));
            Console.WriteLine("====================");
            Console.WriteLine("====================");

            List<Osoba> osoby = new List<Osoba>();
            osoby.Add(o);
            osoby.Add(new Osoba("Adam", "Adamski"));
            osoby.Add(new Student("Dominika", "Domańska"));
            Console.WriteLine(osoby.Count);
            foreach (Osoba os in osoby)
            {
                Console.WriteLine(os);
            }
            osoby.Sort();
            Console.WriteLine("===po sortowaniu=====");
            foreach (Osoba os in osoby)
            {
                Console.WriteLine(os);
            }
            osoby.Sort(Osoba.GetComparerByNameLength());
            Console.WriteLine("===sort inaczej=====");
            foreach (Osoba os in osoby)
            {
                Console.WriteLine(os);
            }

        }

        static bool porownaj(Osoba o1, Osoba o2)
        {
            return o1.Equals(o2);
        }
    }
}
