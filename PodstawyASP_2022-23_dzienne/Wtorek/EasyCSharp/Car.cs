using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EasyCSharp
{
    class Car : Vehicle, IComparable<Car>
    {
        public String PlateNumber { private set; get; }
        public Car(string plateNumber, string Owner, int productionYear) 
            : base(Owner, productionYear)
        {
            this.PlateNumber = plateNumber;
        }

        public int CompareTo([AllowNull] Car other)
        {
            return this.PlateNumber.CompareTo(other.PlateNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
                return this.PlateNumber.Equals( ((Car) obj).PlateNumber);
            return false;
        }

        public override int GetHashCode()
        {
            return this.PlateNumber.GetHashCode();
        }

        public static IComparer<Car> GetComparerByProductionYear()
        {
            return new ComparerByProductionYear();
        }

        private class ComparerByProductionYear : Comparer<Car>
        {
            public override int Compare([AllowNull] Car x, [AllowNull] Car y)
            {
                return x.ProductionYear-y.ProductionYear;
            }
        }

    }
}
