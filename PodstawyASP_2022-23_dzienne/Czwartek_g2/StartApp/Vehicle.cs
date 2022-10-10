using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Vehicle
    {
        public String Owner { private set; get; }
        public int ProductionYear;

        public Vehicle(string Owner, int productionYear)
        {
            this.Owner = Owner;
            ProductionYear = productionYear;
        }

        public override string ToString()
        {
            return "właściciel: " + Owner;
        }
    }
}
