using System;
using System.Collections.Generic;

namespace EasyCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle v = new Vehicle("Adam", 1956);
            Console.WriteLine(v.Owner);
            //v.Owner = "Eliza";
            Console.WriteLine("Pojazd -- "+v);
            v = null;
            Car c = new Car("EL1234A","Eliza", 2018);
            Console.WriteLine("Samochód -- " + c);
            List<Car> cars = new List<Car>();
            cars.Add(new Car("ELW213B", "Tamara", 1998));
            cars.Add(c);
            cars.Add(new Car("EL2134B", "Tomasz", 2022));
            cars.Add(new Car("EL2134B", "Tadeusz", 2022));
            Console.WriteLine(cars[2]);
            Console.WriteLine("=======================");
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine(cars[i]);
            }
            cars.Sort();
            Console.WriteLine("-----------------------");
            foreach (Car cItem in cars)
            {
                Console.WriteLine(cItem);
            }
            cars.Sort(Car.GetComparerByProductionYear());
            Console.WriteLine("-----------------------");
            foreach (Car cItem in cars)
            {
                Console.WriteLine(cItem);
            }
            HashSet<Car> setOfCars = new HashSet<Car>();
            foreach (Car cItem in cars)
            {
                setOfCars.Add(cItem);
            }
            Console.Write("Rozmiar zbioru samochodów:");
            Console.WriteLine(setOfCars.Count);
            Console.WriteLine("+++++++++++++++++++++++");
            foreach (Car cItem in setOfCars)
            {
                Console.WriteLine(cItem);
            }
            Dictionary<String, Car> mapOfCars = new Dictionary<string, Car>();
            foreach (Car cItem in cars)
            {
                mapOfCars.Add(cItem.Owner, cItem);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine(mapOfCars["Tamara"]);






        }

    }
}
