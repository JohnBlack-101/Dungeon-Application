using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //make it public, make it a child of character
    //Character includes Name, HitChance, Block, Life and MaxLife
    public class Player : Character
    {

        //Fields - none
        //Properties
        public string Description { get; set; }

        public Weapon EquippedWeapon { get; set; } //CONTAINMENT
        public int Score { get; set; }

        //Constructors
        public Player()
        {
            
        }
        public Player(string name, int hitChance, int block, int maxLife, Weapon equippedWeapon, string description) : base(name, hitChance, block, maxLife)
        {
            EquippedWeapon = equippedWeapon;
            Description = description;
        }
        //Methods
        public override string ToString()
        {
            //A description for the race:
            

            //add the weapon and the description to the base.ToString()
            return base.ToString() + $"Weapon:\t{EquippedWeapon}\n" +
                                     $"Description: {Description}\n" +
                                     $"You have defeated {Score} minion(s)";
        }//end ToString()

        //override CalcHitChance/CalcDamage... 
        public static Player GetPlayer()
        {
            //Create Weapon - Weapon w1 = new()
            Weapon w1 = new("Nunchaku", 15, 25, 30, true,WeaponType.Nunchaku);
            Weapon w2 = new("Knives", 15, 20, 20, true, WeaponType.Knives);
            Weapon w3 = new("Chain", 15, 20, 35, true, WeaponType.Chain);

            //Create all the player characters that you want the user to choose
            Player p1 = new("Ah Sahm", 50, 40, 100, w1, "Ah Sahm came to Chinatown to find his sister and has had the misfortune of being bought by the Hop Wei.\nHe is the best fighter in the Hop Wei Tong and loyal to his brothers and friends.\n");

            Player p2 = new("Young Jun", 45, 30, 90, w2, "Born into a life of Tong violence, Young Jun is the leader of the Hop Wei Tong.\nHe has an undying devotion to the Tong and will do anything to lead it better than his father ever could.\n");

            Player p3 = new("Hong", 43, 30, 85, w3, "Hong is a newer recruit to the Hop Wei that has proven himself in combat and loyalty.\nHe's honestly a nice guy...until you cross one of his Hop Wei brothers.\n");

            //Add them all to a list 
            List<Player> players = new()
            {
                p1, p2, p3
            };
            //Show them to the user by iterating through the collection 
            int index = 1;
            foreach (Player player in players)
            {
                Console.WriteLine($"{index++} - {player.Name}");
            }
            //Let the user make a selection
            Console.WriteLine("Please Select Your Warrior\n");
            string choice = Console.ReadKey(true).KeyChar.ToString();
            int.TryParse(choice, out int i);
            i--;
            //Return the user's selection 
            return players[i];
        }
        public override int CalcDamage()
        {
            //create the return object
            int result;
            //setup necessary resources
            Random rand = new Random();
            //modify the return object
            int minDamage = EquippedWeapon.MinDamage;
            int maxDamage = EquippedWeapon.MaxDamage;
            //if (EquippedWeapon.Type == WeaponType.Bow && PlayerRace == Race.Elf)
            //{
            //    minDamage += 3;
            //    maxDamage += 5;
            //}
            result = rand.Next(minDamage, maxDamage + 1);
            //return the return object
            return result;

            //return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }

        public string playername(Player player)
        {
            return player.Name;
        }

    }
}
