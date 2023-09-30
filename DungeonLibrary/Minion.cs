using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public, make it a child of Character
    public class Minion : Character
    {
        //unique fields
        private int _minDamage;

        //unique props
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            //custom business rule, value must be greater than 0 and less than MaxDamage.
            set
            {
                if ((value > 0 && value < MaxDamage))
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
            //set { _minDamage = (value > 0 && value < MaxDamage) ? value : 1; }              
        }
        public Minion(string name, int hitChance, int block, int maxLife, int minDamage, int maxDamage, string description) : base(name, hitChance, block, maxLife)
        {
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
        }

        public Minion()
        {

        }
        public override string ToString()
        {
            return $"\n********** MINION **********\n" +
                   base.ToString() +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Description: {Description}\n";
        }

        public override int CalcDamage()
        {
            //throw new NotImplementedException();
            int result;//create the return object

            Random rand = new Random();//setup necessary resources

            result = rand.Next(MinDamage, MaxDamage + 1);//modify the return object

            return result;//return the return object
        }

        public static Minion GetMinion()
        {
            //create the return object
            Minion m = new();
            //setup necessary resources
            Minion m1 = new("Thug", 25, 20, 15, 10, 15, "Basically a Criminal Intern\n");
            Minion m2 = new("Brawler", 30, 20, 20, 10, 20, "Fights Dirty and Without Mercy\n");
            Minion m3 = new("Ninja", 40, 30, 25, 8, 20, "A Master of Stealth\n");
            Minion m4 = new("Swordsman", 40, 35, 25, 8, 20, "Blades and More Blades\n");
            Minion m5 = new("A Kung Fu Master", 45, 40, 50, 15, 30, "Pretty Self Explanatory\n");
            List<Minion> minions = new()
            {
                m1, m1, m1, m1, m1,//5/17
                m2, m2, m2,        //3/17
                m3, m3, m3, m3,    //4/17
                m4, m4, m4, m4,    //4/17
                m5, m5                //2/17
            };
            Random rand = new Random();
            int randomIndex = rand.Next(minions.Count);
            //modify the return object
            m = minions[randomIndex];
            //return the return object
            return m;

            //refactor
            //return monsters[new Random().Next(monsters.Count)];
        }
    }
}
