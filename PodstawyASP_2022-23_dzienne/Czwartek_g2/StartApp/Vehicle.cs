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

        public override bool Equals(object obj)
        {
            if (!(obj is Vehicle))
            {
                return false;
            }
            Vehicle v = (Vehicle)obj;
            return Owner.Equals(v.Owner) && ProductionYear == v.ProductionYear;
        }







        
    }
}
