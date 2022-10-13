using System;
using System.Collections.Generic;

namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle v = new Vehicle("Alicja", 2020);
            Console.WriteLine(v.Owner);
            Console.WriteLine("Pojazd: "+v);
            v = new Vehicle("Edward", 2019);
            Vehicle v2 = new Vehicle("Edward", 2019);
            Console.WriteLine(v == v2);
            Console.WriteLine(v.Equals(v2));
            List<Car> listOfCars = new List<Car>();
            listOfCars.Add(new Car("Dagmara", 2021, "EL72235AX"));
            listOfCars.Add(new Car("Dariusz", 2005, "EL32635ZV"));
            listOfCars.Add(new Car("Genowefa", 1998, "EL52635WW"));
            Console.WriteLine("================");
            for (int i =0; i<listOfCars.Count; i++)
            {
                Console.WriteLine(listOfCars[i]);
            }
            listOfCars.Sort();
            Console.WriteLine("----------------");
            foreach (Car c in listOfCars)
            {
                Console.WriteLine(c);
            }
            listOfCars.Sort(Car.GetComparerByProductionYear());
            Console.WriteLine("++++++++++++++++");
            foreach (Car c in listOfCars)
            {
                Console.WriteLine(c);
            }
            HashSet<Car> setOfCars = new HashSet<Car>();
            foreach (Car c in listOfCars)
            {
                setOfCars.Add(c);
            }
            Console.WriteLine(setOfCars.Count);
            setOfCars.Add(listOfCars[1]);
            Console.WriteLine(setOfCars.Count);
            setOfCars.Add(new Car("Gen", 1998, "EL52635WW"));
            Console.WriteLine(setOfCars.Count);

            Console.WriteLine("++++++++++++++++");
            Dictionary<String, Car> dictOfCars = new Dictionary<string, Car>();
            foreach (Car c in listOfCars)
            {
                dictOfCars.Add(c.Owner, c);
            }
            Console.WriteLine(dictOfCars["Dariusz"].PlateNumber);
            Console.WriteLine("++++++++++++++++");
            foreach (String key  in dictOfCars.Keys)
            {
                Console.WriteLine(dictOfCars[key]);
            }

        }
    }
}






