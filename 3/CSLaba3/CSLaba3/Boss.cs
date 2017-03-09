using System;

namespace CSLaba3
{
    class Boss
    {
        private static Boss instance;
        private Boss()
        {
            Console.WriteLine("It's IMBA creature!!!!");
        }
        public static Boss getInstance()
        {
            if (instance == null)
                instance = new Boss();
            return instance;
        }
    }
}
