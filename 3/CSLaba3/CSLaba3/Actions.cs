namespace CSLaba3
{
    interface Actions
    {
        void HealHp(Warrior w);
        void HealMp(Warrior w);
        void Attack(Warrior w);
        int DoubleDamage();
        void CriticalHit(Warrior w);
        void ReduceDamage(Warrior w);
        bool IsDead();
    }
}
