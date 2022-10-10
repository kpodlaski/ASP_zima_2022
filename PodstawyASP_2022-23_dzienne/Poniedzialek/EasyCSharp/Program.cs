using System;

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
            Car c = new Car("Eliza", 2018);
            Console.WriteLine("Samochód -- " + c);

        }
    }
}
