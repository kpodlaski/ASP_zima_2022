using System;
using System.Collections.Generic;
using System.Text;

namespace StartApp
{
    class Car : Vehicle
    {
        public String ID;

        public Car(String owner, int prodYear): base(owner,prodYear)
        {
            
        }
    }
}
