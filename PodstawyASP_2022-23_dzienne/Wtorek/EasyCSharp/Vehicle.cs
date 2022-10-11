using System;
using System.Collections.Generic;
using System.Text;

namespace EasyCSharp
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
            return "Owner: " + Owner + " prod. year: " + ProductionYear;
        }
    }
}
