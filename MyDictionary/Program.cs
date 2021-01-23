using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> carsOfEmployees = new MyDictionary<int,string>();

            carsOfEmployees.Add(1, "Honda Civic: 16TT898");
            carsOfEmployees.Add(2, "Renault Clio 2 : 41AD219");

            foreach (var item in carsOfEmployees.Keys)
            {

                Console.WriteLine(item);
            }

            foreach (var item in carsOfEmployees.Values)
            {
                Console.WriteLine(item);
            }

        }
    }
}
