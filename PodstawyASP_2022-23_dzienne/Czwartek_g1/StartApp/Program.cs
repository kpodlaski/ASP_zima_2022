using System;

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
        }
    }
}
