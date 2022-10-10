using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Osoba
    {
        public String Imie { private set; get; }
        public String Nazwisko;

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
    }
}
