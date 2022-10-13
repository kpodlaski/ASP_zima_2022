using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace StartApp
{

    class Car : Vehicle, IComparable<Car>
    {
        public String PlateNumber;
        
        public Car(String owner, int prodYear, String plate) : base(owner, prodYear)
        {
            this.PlateNumber = plate;
        }

        public int CompareTo(Car other)
        {
            return this.PlateNumber.CompareTo(other.PlateNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj is Car)
                return PlateNumber.Equals(((Car)obj).PlateNumber);
            return false;
        }

        public override int GetHashCode()
        {
            return PlateNumber.GetHashCode();
        }

        public static IComparer<Car> GetComparerByProductionYear()
        {
            return new CarComparerByProductionYear();
        }

        class CarComparerByProductionYear : IComparer<Car>
        {
            public int Compare(Car x, Car y)
            {
                return x.ProductionYear - y.ProductionYear;
            }
        }
    }
}
