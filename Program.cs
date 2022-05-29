using System;
using DungeonRpg.src.Entities;

namespace DungeonRpg
{
    class Program 
    {
        static void Main(string[] args)
        {
          Hero Arus = new Hero("Arus", 23, "Knight");
          Wizard Wizard = new Wizard("Jennica", 23, "White Wizard");

          Console.WriteLine(Arus.Attack());
          Console.WriteLine(Wizard.Attack());
        }
    }
}
