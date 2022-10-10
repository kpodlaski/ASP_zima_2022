using System;

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

        }
    }
}
