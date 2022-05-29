using System;
using DungeonRpg.src.Entities;

namespace DungeonRpg
{
    class Program 
    {
        static void Main(string[] args)
        {
          Knight Arus = new Knight("Arus", 23, "Knight", 200, 30);
          Wizard Jenica = new Wizard("Jennica", 23, "White Wizard,", 100, 80);
          BlackWizard Topapa = new BlackWizard("Topapa", 24, "Black Wizard", 110, 90);

          Console.WriteLine("Os Dados rolam, Sua Party atacou: ");
          
          Console.WriteLine(Arus.Attack());          

          Console.WriteLine(Jenica.Attack());
          Console.WriteLine(Jenica.MageAttack(1));
          Console.WriteLine(Jenica.MageAttack(7));

          Console.WriteLine(Topapa.Attack());
          Console.WriteLine(Topapa.MageAttack(1));
          Console.WriteLine(Topapa.MageAttack(10));



        }
    }
}
