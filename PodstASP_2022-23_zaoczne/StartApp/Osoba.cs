using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StartApp
{
    class Osoba : IComparable
    {
        public String Imie { private set; get; }
        private String Nazwisko;

        public Osoba(string Imie, string nazwisko)
        {
            this.Imie = Imie;
            Nazwisko = nazwisko;
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko;
        }

        public override bool Equals(object obj)
        {
            if (obj is Osoba)
            {
                Osoba o = (Osoba)obj;
                return Imie.Equals(o.Imie) && Nazwisko.Equals(o.Nazwisko);
            }
            else return false;
        }

        public override int GetHashCode()
        {
            return Imie.GetHashCode() + Nazwisko.GetHashCode(); 
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Osoba))
                return 0;
            Osoba o2 = (Osoba) obj;
            return Nazwisko.CompareTo(o2.Nazwisko);
        }

        static public  IComparer<Osoba> GetComparerByNameLength()
        {
            return new CompareByNameLength();
        }
        
        class CompareByNameLength : IComparer<Osoba>
        {
            public int Compare(Osoba x, Osoba y)
            {
                int l1 = x.Nazwisko.Length;
                int l2 = y.Nazwisko.Length;
                return -(l1 - l2);
            }
        }
    }
}
