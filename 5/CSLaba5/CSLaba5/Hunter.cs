using System;

namespace CSLaba5
{
    public class Hunter : Warrior, Actions
    {
        public delegate void Del();
        public Hunter()
        {

        }
        public Hunter(int h, int d)
        {
            maxHealth = (uint)h;
            Damage = d;
            Health = maxHealth;
        }
        public void HealHp()
        {
            if (Health <= maxHealth - 100)
            {
                Health = Health + 100;
            }
            else Health = maxHealth;
        }
        public void Attack(Hunter h)
        {
            if (h.Health <= Damage) h.Health = 0;
            else h.Health = h.Health - (uint)Damage;
        }
        public bool IsDead()
        {
            if (Health == 0) return true;
            else return false;
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
        public override string ToString()
        {
            string s = "";
            s = "Hunter (" + Health + "/" + maxHealth + ")\n";
            return s;
        }
        public string ToString(string a)
        {
            string s = "";
            s = "Hunter (" + Health + "/" + maxHealth + ")\n" + a;
            return s;
        }
        public static string[] ToArray(Hunter[] hun)
        {
            string[] strm = new string[10];
            for (int i = 0; i < 10; i++)
            {
                if (hun[i].IsDead()) strm[i]= "Hunter (Is Dead!)\n";
                else strm[i] = hun[i].ToString();
            }
            return strm; 
        }
        public void PrintSmth(string slovo)
        {
            Console.WriteLine("Лол кек " + slovo);
        }
        public event Del NewEv;
        public void M()
        {
            NewEv += Hunter_NewEv;
            NewEv();
            
        }

        public void Hunter_NewEv()
        {
            Console.WriteLine("Vau, sobitie!");
            
        }
    }
}
