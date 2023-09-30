using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {


        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        bool _isTwoHanded;
        WeaponType _type;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //business rule:
                //0 < MinDamage ,= MaxDamage
                if (value > 0 && value <= MaxDamage)
                {
                    //good to go
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
            
        }
        public WeaponType Type 
        {
            get { return _type; }
            set { _type = value; }
        }
        public Weapon()
        {

        }
        public Weapon(string name, int minDamage, int maxDamage, int bonusHitChance, bool isTwoHanded, WeaponType type)
        {
            //ANY props that have business rules that depaend o OTHER properties
            //MUST be assigned AFTER the independent properties are set.
            //MinDamage depends on Max Damage, so MaxDamage must be set first.
            if (minDamage > maxDamage)
            {
                Console.WriteLine("Min Damage must not be more than Max Damage...You cheater.");
            }
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
        }
        //Method:
        public override string ToString()
        {
            //return base.ToString();//namespace.classname
            return $"{Name}\n" +
                   $"Damage: {MinDamage} to {MaxDamage}\n" +
                   $"Bonus Hit: {BonusHitChance}%\n" +
                   $"{(IsTwoHanded ? "Two-" : "One-")}Handed";
                   //$" "//update with Type
        }
    }
}