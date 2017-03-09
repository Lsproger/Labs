using System;

namespace CSLaba3
{
    public delegate string Str(Warrior w);
    public abstract class Warrior
    {
        public void WriteToFile(string location, string contents)
        {
            System.IO.File.WriteAllText(location, contents);
        }
        private uint health, mana;
        public int damage;
        public uint maxMana;
        public uint maxHealth;
        public uint Health
        {
            get { return health; }
            set
            {
                health = value;
            }
        }
        public uint Mana
        {
            get { return mana; }
            set
            {
                mana = value;
            }
        }
        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }
        public Str ToStr = x => "\nClass — " + x.GetType().Name + "\nHealth = " + x.Health +
                                 "\nMana = " + x.Mana + "\nDamage = " + x.Damage +
                                "\n******************************\n";
        public override string ToString()
        {
            return ToStr(this);
        }
        public Memento CreateMemento()
        {
            Console.WriteLine("\nMemento Created!\n");
            return new Memento(this);
        }
    }
}
