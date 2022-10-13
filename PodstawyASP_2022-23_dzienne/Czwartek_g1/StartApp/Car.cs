using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StartApp
{
    class Car : Vehicle, IComparable<Car>
    {
        public String ID;

        public Car(String id, String owner, int prodYear): base(owner,prodYear)
        {
            ID = id;
        }

        public int CompareTo([AllowNull] Car other)
        {
            return ID.CompareTo(other.ID);
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
            {
                return ID.Equals(((Car)obj).ID);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

        static public IComparer<Car> GetComparerByProductionYear()
        {
            return new CompareCarByProductionYear();
        }

        class CompareCarByProductionYear : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.ProductionYear - y.ProductionYear;
            }
        }

    }
}
