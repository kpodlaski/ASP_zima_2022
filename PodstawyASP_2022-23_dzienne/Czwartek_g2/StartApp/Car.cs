using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Car : Vehicle
    {
        public String PlateNumber;
        
        public Car(String owner, int prodYear, String plate) : base(owner, prodYear)
        {
            this.PlateNumber = plate;
        }
    }
}
