using System;

namespace CSLaba3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            Hunter w = new Hunter();
            Hunter ww = new Hunter();
            w.Health = 1000;
            ww.Health = 2000;
            w.Mana = 500;
            w.Damage = 48;
            ww.Damage = 52;
            Hunter h = w + ww;
            Console.WriteLine(w.ToString());
            Console.WriteLine(ww.ToString());
            Console.WriteLine(h.ToString());
            Hunter[] army = new Hunter[size];
            checked
            {
                army = army * w;
                army = army * ww;
            }
            Console.WriteLine(army[0].ToString());
            Console.WriteLine(army[1].ToString());
            checked
            {
                army = army - w;
                army = army - ww;
            }
            try
            {
                Console.WriteLine(army[0].ToString());
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Обращение к элементу по несуществующему индексу!");
                Console.WriteLine("Желаете продолжить работу или исправить ошибку?");
                Console.WriteLine("Продолжить — Y; Исправить — N.");
                if (Console.ReadLine() == "Y") goto Next;
                else goto TheEnd;          
            }
            finally
            {
                Console.WriteLine("\nSomthing to do...\n");
            }
        Next:
            Console.WriteLine(w.ToString());
            w.WriteToFile("D:/wInfo.txt", w.ToString());
            Shaman sh = new Shaman();
            var MyT = sh.Heals();
            Console.WriteLine("{0}\n{1}", MyT.Item1, MyT.Item2); 
            Hunter hu = new Hunter(1000, 500, 40);
            Console.WriteLine(hu.ToString());

            Memento mem1 = hu.CreateMemento();
            ww.Attack(hu);
            Console.WriteLine(hu.ToString());  
            Restorer.RestoreState(ref hu ,ref mem1);
            Console.WriteLine(hu.ToString());
        TheEnd:;
        }
    }
}
