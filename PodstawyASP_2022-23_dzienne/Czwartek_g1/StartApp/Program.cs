using System;
using System.Collections.Generic;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle v = new Vehicle("Adam", 2020);
            Console.WriteLine("Obiekt v:"+v);
            Console.WriteLine(v.Owner);
            v = new Vehicle("Tamara", 2021);
            Vehicle v2 = new Vehicle("Tamara", 2021);
            Console.WriteLine(v == v2);
            Console.WriteLine(v.Equals(v2));
            List<Car> cars = new List<Car>();
            cars.Add(new Car("EL6579AC", "Eliza", 1999));
            cars.Add(new Car("EL15A9VC", "Gerwazy", 2012));
            cars.Add(new Car("ELA579ZX", "Walery", 2008));
            Console.WriteLine("=======================");
            for (int i=0; i<cars.Count; i++)
            {
                Console.WriteLine(cars[i]);
            }
            cars.Sort();
            Console.WriteLine("--------------------");
            foreach(Car c in cars)
            {
                Console.WriteLine(c);
            }
            cars.Sort(Car.GetComparerByProductionYear());
            Console.WriteLine("++++++++++++++++++++");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }
            HashSet<Car> setOfCars = new HashSet<Car>();
            foreach (Car c in cars)
            {
                setOfCars.Add(c);
            }
            setOfCars.Add(new Car("EL15A9VC", "Gerwazy", 2012));
            Console.WriteLine(setOfCars.Count);
            Dictionary<String, Car> dictOfCars = new Dictionary<string, Car>();
            foreach (Car c in cars)
            {
                dictOfCars.Add(c.Owner, c);
            }
            Console.WriteLine(dictOfCars["Eliza"]);
            Console.WriteLine("=====================");
            foreach (String owner in dictOfCars.Keys)
            {
                Console.WriteLine(owner + " => " + dictOfCars[owner]);          
            }






        }
    }
}
