﻿namespace DungeonLibrary
{
    public class Character
    {
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        private int _life;

        public string Name
        {
            get { return _name;}
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set 
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }
            }
        }//end Life

        //CTOR
        public Character()
        {
            //default CTOR
        }

        public Character(string name, int hitChance, int block, int maxLife)
        {
            MaxLife = maxLife;
            Life = MaxLife;//start off with full HP
            Block = block;
            HitChance = hitChance;
            Name = name;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"----- {Name} -----\n" +
                   $"Life: {Life} of {MaxLife}\n" +
                   $"Hit Chance: {HitChance}%\n" +
                   $"Block {Block}%\n\n";
        }

        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}