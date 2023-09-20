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

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
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

        bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

    }
}
