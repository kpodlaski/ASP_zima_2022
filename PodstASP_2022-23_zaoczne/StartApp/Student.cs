using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Student : Osoba
    {
        private static long lastIndexNr=1;
        public long NrIndeksu { get; set; }
        
        public Student(String imie, String nazwisko): base(imie, nazwisko)
        {
            NrIndeksu = lastIndexNr++;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student)
            {
                return NrIndeksu == ((Student)obj).NrIndeksu;
            }
            return false; //base.Equals(obj);
        }
    }
}
