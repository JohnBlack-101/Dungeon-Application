using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace DungeonApp
{
    public class TestHarness
    {
        static void Main(string[] args)
        {
            Character c1 = new Character();
            //now that we have a character, we can access the properties to store info in the fields using the "set"
            c1.Name = "Lee";
            c1.HitChance = 60;
            c1.Block = 100;
            c1.MaxLife = 100;
            c1.Life = 100;

            //now let's do the weaponry
            //Weapon w1 = new Weapon("Nunchaku", 50,150,70,true);
            //w1.Name = "Nunchaku";
            //w1.MinDamage = 50;
            //w1.MaxDamage = 150;
            //w1.BonusHitChance = 70;
            //w1.IsTwoHanded = true;
        }
    }
}       