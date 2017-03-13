using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace CSLaba5
{
    delegate int del(int del); 
    public delegate void Del();
    class Program
    {
       
       
         

        static void Main()
        {
            //Reflector.ToTXT("CSLaba5.Hunter", "D:\\HunterInfo.txt");
            //Console.WriteLine("All methods:");
            //Reflector.ToConsole(Reflector.GetAllMeth("CSLaba5.Hunter"));
            //Console.WriteLine("\nAll fields & properties:");
            //Reflector.ToConsole(Reflector.GetFields("CSLaba5.Hunter"));
            //Console.WriteLine("\nAll interfaces:");
            //Reflector.ToConsole(Reflector.GetInterf("CSLaba5.Hunter"));
            //Reflector.GetMethWithParam("CSLaba5.Hunter", "Hunter[]");
            //Reflector.CallSomeMeth("CSLaba5.Hunter", "PrintSmth", "D:\\inf.txt");
            Hunter h = new Hunter();
            for (int i = 0; i < 100; i++)
            {
                if (i == 50) h.M();
                
            }
            
            del myDelegate = x => x * x;
            int j = myDelegate(5); //j = 25  
            Console.WriteLine(myDelegate(10));

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
