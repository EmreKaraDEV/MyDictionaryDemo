using System;

namespace MyDictionaryDemo
{
    class Program
    {
        //My Dictionary Demo
        static void Main(string[] args)
        {
            MyDictionary<String, int> vehicles = new MyDictionary<string, int>();
            vehicles.Add("Sport Car", 5000);
            vehicles.Add("Tractor", 2000);
            vehicles.Add("Truck", 3000);
            vehicles.Add("Helicopter", 10000);
            vehicles.Add("Plane", 25000);

            Console.WriteLine(vehicles.Length());
        }
    }
}
