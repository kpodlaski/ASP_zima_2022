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
            Console.WriteLine("====================");
            Console.WriteLine(osoby[2]);
            HashSet<Osoba> zbiorOsob = new HashSet<Osoba>();
            for (int i=0; i<osoby.Count; i++)
            {
                zbiorOsob.Add(osoby[i]);
            }
            Console.WriteLine("====================");
            Console.WriteLine("Rozmiar zbioru");
            Console.WriteLine(zbiorOsob.Count);
            zbiorOsob.Add(o);
            Console.WriteLine("Dodajemy obiekt ponownie");
            Console.WriteLine("Rozmiar zbioru");
            Console.WriteLine(zbiorOsob.Count);
            Console.WriteLine("Dodajemy obiekt równy innemu ze zbioru");
            Console.WriteLine("Rozmiar zbioru");
            zbiorOsob.Add(new Osoba("Karolina", "Karolewska"));
            Console.WriteLine(zbiorOsob.Count);
            Console.WriteLine("Dodajemy obiekt o takim samych hashu co element ze zbioru");
            Console.WriteLine("Rozmiar zbioru");
            zbiorOsob.Add(new Osoba("Karolewska", "Karolina"));
            Console.WriteLine(zbiorOsob.Count);
            foreach (Osoba os in zbiorOsob)
            {
                Console.WriteLine(os);
            }
            Dictionary<Osoba, double> pensjeOsob = new Dictionary<Osoba, double>();
            foreach (Osoba os in zbiorOsob)
            {
                pensjeOsob.Add(os, os.Imie.Length * 102.2);
            }
            Console.WriteLine("====================");
            Console.WriteLine(pensjeOsob[o]);
            Console.WriteLine("--------------------");
            foreach (Osoba os in pensjeOsob.Keys)
            {
                Console.WriteLine(os +" ==> "+ pensjeOsob[os]+ "$" );
            }
            
        }

        static bool porownaj(Osoba o1, Osoba o2)
        {
            return o1.Equals(o2);
        }
    }
}
