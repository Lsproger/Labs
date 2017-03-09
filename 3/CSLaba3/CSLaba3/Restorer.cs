using System;

namespace CSLaba3
{
    public static class Restorer
    {
         public static void OutState(Memento memento)
         {
             Console.WriteLine("*****Restored memento*****\nHealth = {0}\nMana = {1}\n**************************\n",
                              memento.HpState, memento.MpState);
         } 
        public static void RestoreState(ref Hunter hunt,ref Memento mem)
        {
            hunt.Health = mem.HpState;
            hunt.Mana = mem.MpState;
        }

    }
}
