using System;

namespace CSLaba3
{
    public sealed partial class Shaman : Warrior, Actions
    {
        public void HealHp(Warrior w)
        {
            if ((w.Health + 200) >= w.maxHealth) w.Health = w.maxHealth;
            else w.Health = (w.Health + 200);
        }
        public void HealMp(Warrior w)
        {
            if ((w.Mana + 150) >= w.maxMana) w.Mana = w.maxMana;
            else w.Mana = (w.Mana + 150);
        }
        public void ReduceDamage(Warrior w)
        {
            w.Damage = w.Damage - 40;
        }
        public bool IsDead()
        {
            if (Health == 0) return true;
            else return false;
        }
        public Tuple<string, string>  Heals()
        {
            string Hp = "Healing hp = 200";
            string Mp = "Healing mp = 150";
            return Tuple.Create(Hp, Mp);
        }
        public void WriteToFile(string location, string contents)
        {
            contents = "Heh, guy, you were trolled! \n Im'm just amazing Shaman, that helps my King";
            System.IO.File.WriteAllText(location, contents);
        }
    }
}
