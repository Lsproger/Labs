using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLaba5
{
    public class Game
    {
        public int queue = 1;
        public int numbOfTerms = 0;
        Hunter buffH;
        public string[] chat = new string[1000];
        Hunter[] RArmy = new Hunter[10];
        Hunter[] GArmy = new Hunter[10];
        Random R = new Random();
        private static Game instance;
        private Game()
        {
            for (int i = 0; i < 10; i++)
            {
                RArmy[i] = new Hunter(R.Next(100, 100), R.Next(10, 100));
                GArmy[i] = new Hunter(R.Next(100, 100), R.Next(10, 100));
            }
            chat[numbOfTerms] = "Game is started!!!\n First turn — Red team.";
        }
        public static Game getInstance()
        {
            if (instance == null)
                instance = new Game();
            return instance;
        }
        public void RePrint(Form1 form)
        {
            form.textBox1.Lines = Hunter.ToArray(RArmy);
            form.textBox2.Lines = Hunter.ToArray(GArmy);
            form.textBox3.Lines = chat;
        }
        public void HAttack()
        {
            if (queue % 2 == 0)
            {
                buffH = GFindAlive();
                buffH.Attack(RFindAlive());
                chat[numbOfTerms + 1] = "Green attacks Red for -" + buffH.Damage + "hp!\n  ***RED TEAM TURN!***";

            }
            else
            {
                buffH = RFindAlive();
                buffH.Attack(GFindAlive());
                chat[numbOfTerms + 1] = "Red attacks Green for -" + buffH.Damage + "hp!\n  ***GREEN TEAM TURN!***";

            }
            numbOfTerms++;
            queue++;

            Attack(this, new EventArgs());
        }
        public void HHeal()
        {
            Injured().HealHp();
            if (queue % 2 == 0)
            {
                chat[numbOfTerms + 1] = "Green team HEALING for +100 hp!!!  \n***RED TEAM TURN!***";
            }
            else
            {
                chat[numbOfTerms + 1] = "Red team HEALING for +100 hp!!!  \n***GREEN TEAM TURN!***";
            }
            numbOfTerms++;
            queue++;
            Healing(this, new EventArgs());
        }
        private Hunter RFindAlive()
        {
            int Rh = R.Next(10);
            if (RArmy[Rh].IsDead() == true)
            {
                return RFindAlive();
            }
            else return RArmy[Rh];
        }
        private Hunter GFindAlive()
        {
            int Gh = R.Next(10);
            if (GArmy[Gh].IsDead() == true)
            {
                return GFindAlive();
            }
            else return GArmy[Gh];
        }
        private Hunter Injured()
        {
            if (queue % 2 == 0)
            {
                bool check = false;
                for (int i=0; i< 10; i++)
                {
                    if (GArmy[i].Health == GArmy[i].maxHealth || GArmy[i].IsDead() == true)
                    {
                        return GArmy[0];
                    } 
                }
                
                int Gh = R.Next(10);
                if (GArmy[Gh].Health != GArmy[Gh].maxHealth && GArmy[Gh].IsDead() != true)
                {
                    return GArmy[Gh];
                }
                else return Injured();
                }
            
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (RArmy[i].Health == RArmy[i].maxHealth || RArmy[i].IsDead() == true)
                    {
                        return RArmy[0];
                    }
                }
                int Rh = R.Next(10);
                if (RArmy[Rh].Health != RArmy[Rh].maxHealth && RArmy[Rh].IsDead() != true)
                {
                    return RArmy[Rh];
                }
                else return Injured();
            }
        }
        public static bool IsDestr()
        {
            bool Rt = true;
            bool Gt = true;
            for (int i = 0; i < 10; i++)
            {
                if (Game.getInstance().RArmy[i].IsDead() != true) Rt = false;
                if (Game.getInstance().GArmy[i].IsDead() != true) Gt = false;
            }
            if (Rt==true||Gt==true) return true;
            else return false;
        }
        public event EventHandler Attack;
        public event EventHandler Healing;
    }
}
