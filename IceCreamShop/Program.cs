using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;



            /* ===== Sort Flavors ===== */
            Console.WriteLine("Flavors");
            Console.WriteLine("=== Before ===");
            foreach(Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }
            
            availableFlavors.Sort(new FlavorComparer());

            Console.WriteLine("\n=== After ===");
            foreach (Flavor f in availableFlavors)
            {
                Console.WriteLine(f.Name);
            }

            /* ===== Sort Cones ===== */
            Console.WriteLine("Flavors");
            Console.WriteLine("=== Before ===");
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c.Cost);
            }

            availableFlavors.Sort(new FlavorComparer());

            Console.WriteLine("\n=== After ===");
            foreach (Cone c in availableCones)
            {
                Console.WriteLine(c.Cost);
            }
        }
    }
}
