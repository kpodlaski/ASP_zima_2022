using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Vehicle
    {
        public String Owner { private set; get; }
        public int ProductionYear;

        public Vehicle()
        {
            Owner = "John Doe";
            ProductionYear = 0;
        }

        public Vehicle(string Owner, int productionYear)
        {
            this.Owner = Owner;
            ProductionYear = productionYear;
        }

        public override string ToString()
        {
            return "Właściciel:" + Owner + " rok prod.:" + ProductionYear;
        }

        public override bool Equals(object obj)
        {
            if (obj is Vehicle)
            {
                Vehicle o = (Vehicle)obj;
                return Owner.Equals(o.Owner) && ProductionYear == o.ProductionYear;
            }
            else return false;
        }
    }
}
