using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SuckMyUnit
{
    class Program
    {
        static void Main(string[] args)
        {

           InfantryPlt();
           Console.WriteLine("");
           ArtyCompany();
           Console.WriteLine("");
           Tank();
        }

        private static void Tank()
        {
            Soldier joe = new Enlisted();
            Soldier pl = new Officer();
            Soldier chief = new Warrant();
            Weapon tank = new Tank();
            Units platoon = new Platoon();

            Console.WriteLine($"A typical armor platoon consists of: {platoon.strength} Personnel");
            Console.WriteLine("All the enlisted men say " + joe.Describe());
            Console.WriteLine("While the officer says " + pl.Describe());
            Console.WriteLine("The maintenance chief says " + chief.Describe());
            Console.WriteLine("Soldiers use the " + tank.Name);
            Console.WriteLine("With a " + tank.Load());


        }

        private static void ArtyCompany()
        {
            Soldier joe = new Enlisted();
            Soldier pl = new Officer();
            Weapon weapon = new Artillery();
            Units company = new Company();

            Console.WriteLine($"A typical Artillery platoon consists of: {company.strength} Personnel");
            Console.WriteLine("All the enlisted men say " + joe.Describe());
            Console.WriteLine("While the officer says " + pl.Describe());
            Console.WriteLine("Soldiers use the " + weapon.Name);
            Console.WriteLine("With a " + weapon.Load());

        }

        static void InfantryPlt()
        {
            Soldier joe = new Enlisted();
            Soldier pl = new Officer();
            Weapon rifle = new Rifle();
            Units platoon = new Platoon();
            
            Console.WriteLine($"A typical Infantry company consists of: {platoon.strength} Personnel");
            Console.WriteLine("All the enlisted men say " + joe.Describe());
            Console.WriteLine("While the officer says " + pl.Describe());
            Console.WriteLine("Every Soldier carries a " + rifle.Name);
            Console.WriteLine("Loaded with " + rifle.Load());
        }
    }
}