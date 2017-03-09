namespace CSLaba3
{
    public sealed class Memento
    {
        public Memento(Warrior w)
        {
            HpState = w.Health;
            MpState = w.Mana;
        }
        private uint hpState, mpState;
        public uint HpState
        {
            get { return hpState; }
            set
            {
                hpState = value;
            }
        }
        public uint MpState
        {
            get { return mpState; }
            set
            {
                mpState = value;
            }
        }
    }
}
