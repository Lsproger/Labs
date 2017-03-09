using System;

namespace CSLaba3
{
    public class Hunter : Warrior, Actions
    {

        public Hunter() { }
        public Hunter(int h, int m, int d)
        {
            maxHealth = (uint)h;
            maxMana = (uint)m;
            Damage = d;
            Health = maxHealth;
            Mana = maxMana;
        }
        public void HealHp(Warrior w) { }
        public void HealMp(Warrior w) { }
        public void Attack(Warrior w)
        {
            w.Health = w.Health - (uint)Damage;
        }
        public int DoubleDamage()
        {
            return Damage * 2;
        }
        public void CriticalHit(Warrior w)
        {
            w.Health = w.Health - (uint)Damage * 3;
        }
        public void ReduceDamage(Warrior w) { }
        public bool IsDead()
        {
            if (Health == 0) return true;
            else return false;
        }
        public override bool Equals(Object obj)
        {
            Console.WriteLine("\nOoooh, sorry, this method do NOTHNG, dumn!\n");
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            Console.WriteLine("\nWooooh! It's GetHashCode method!!!\n");
            return base.GetHashCode();
        }
        public static Hunter operator +(Hunter h1, Hunter h2)
        {
            Hunter h = new Hunter();
            h.Damage = h1.Damage + h2.Damage;
            h.maxHealth = h1.maxHealth + h2.maxHealth;
            h.maxMana = h1.maxMana + h2.maxMana;
            h.Health = h.maxHealth;
            h.Mana = h.maxMana;
            return h;
        }
        public static Hunter[] operator *(Hunter[] h1, Hunter h2)
        {
            Array.Resize(ref h1, h1.Length + 1);
            h1[h1.Length-1] = h2;
            return h1;
        }
        public static Hunter[] operator -(Hunter[] h1, Hunter h2)
        {

            int k = -1;
            do
            {
                k++;
            } while (h1[k] != h2);
            if (h1[k] == h2 && k - 1 < h1.Length)
                for (int j = k; j < h1.Length - 1; j++)
                    h1[j] = h1[j + 1];
            Array.Resize(ref h1, h1.Length - 1);
            if (h1.Length == 0)
            {
                Console.WriteLine("Ваша армия повержена, милорд!");
            }
            return h1;
        }
    }
}
