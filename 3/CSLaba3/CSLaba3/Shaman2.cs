namespace CSLaba3
{
    public sealed partial class Shaman
    {
        public void Attack(Warrior w)
        {
            if (w.Health - (uint)Damage <= 0) w.Health = 0;
            else w.Health = w.Health - (uint)Damage;
        }
        public int DoubleDamage()
        {
            return Damage * 2;
        }
        public void CriticalHit(Warrior w) { }
    }
}
