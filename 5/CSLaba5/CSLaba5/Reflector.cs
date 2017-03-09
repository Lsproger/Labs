using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Collections;

namespace CSLaba5
{
    static class Reflector
    {
        public static void ToTXT(string className, string path)
        {
            StreamWriter F = new StreamWriter(path);
            try
            {
                F.WriteLine("Content of your class:"); // инф-ия об объекте этой коллекции
                for (int i = 0; i < AllF(className).Length; i++)
                    F.WriteLine(AllF(className)[i].ToString());
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine("File isn't found because of " + exc.Message);
            }
            catch (FieldAccessException exc)
            {
                Console.WriteLine("There wasn't access to the file because of " + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Unknown exception: " + exc.Message);
            }
            finally
            {
                Console.WriteLine("Filing information about your Collection_type object is finished");
                if (F != null) // если исключения не возникли
                { F.Close(); }
            }
        }

        public static string[] GetAllMeth(string className)
        {
            Type myType = Type.GetType(className, false, true);
            string[] meths = new string[myType.GetMethods().Length];
            for (int i = 0; i < myType.GetMethods().Length; i++)
            {
                meths[i] = myType.GetMethods()[i].ToString();
            }
            return meths;
        }

        public static string[] GetFields(string className)
        {
            Type myType = Type.GetType(className, false, true);
            int fL, pL;
            fL = myType.GetFields().Length;
            pL = myType.GetProperties().Length;
            string[] fieldsInf = new string[fL + pL];
            for (int i = 0; i < fL; i++)
            {
                fieldsInf[i] = myType.GetFields()[i].ToString() + "(Field)";
            }
            for (int i = 0; i < pL; i++)
            {
                fieldsInf[i + fL] = myType.GetProperties()[i].ToString() + "(Prop.)";
            }
            return fieldsInf;
        }

        public static string[] GetInterf(string className)
        {
            Type myType = Type.GetType(className, false, true);
            string[] meths = new string[myType.GetInterfaces().Length];
            for (int i = 0; i < myType.GetInterfaces().Length; i++)
            {
                meths[i] = myType.GetInterfaces()[i].ToString();
            }
            return meths;
        }

        public static string[] AllF(string className)
        {
            int ml = GetAllMeth(className).Length;
            int fl = GetFields(className).Length;
            int il = GetInterf(className).Length;
            string[] allF = new string[ml + fl + il];
            for (int i = 0; i < ml; i++) allF[i] = GetAllMeth(className)[i] + "   *METHOD*";
            for (int i = 0; i < fl; i++) allF[i + ml] = GetFields(className)[i] + "   *FIELD/PROP.*";
            for (int i = 0; i < il; i++) allF[i + ml + fl] = GetInterf(className)[i] + "   *INTERFACE*";
            return allF;
        }

        public static void ToConsole(string[] m)
        {
            foreach (string smth in m)
            {
                Console.WriteLine(smth);
            }
        }

        public static void GetMethWithParam(string className, string methType)
        {
            Type myType = Type.GetType(className, false, true);
            Console.WriteLine("\nМетоды класса " + className + " с параметром " + methType + ":");
            for (int i = 0; i < myType.GetMethods().Length; i++)
            {
                bool mb = false;
                ParameterInfo[] parameters = myType.GetMethods()[i].GetParameters();
                for (int j = 0; j < parameters.Length; j++)
                {
                    if (parameters[j].ParameterType.Name == methType) mb = true;
                }
                if (mb == true) Console.WriteLine(myType.GetMethods()[i]);
            }
        }

        public static void CallSomeMeth(string cl, string me, string document)
        {
            StreamReader R = new StreamReader(document);        //Следующие три строки мы читаем файл и записываем первую
            string param1 = R.ReadLine();                       //строку в переменную param1
            R.Close();                                          // Закрыли потом чтения
            object[] param = { param1 };                        // а param1 в массив типа object[] чтобы передать эти параметры при вызове метода

            Type t = Type.GetType(cl, false, true);         // Создали переменную типа, который записан в "cl"!!!!!!
                
            object obj = t.InvokeMember(null,                   // В этом блока мы вызываем конструктор того типа,
            BindingFlags.DeclaredOnly |                         // метод которого будем вызывать
            BindingFlags.Public | BindingFlags.NonPublic |      // В нашем случае это то, что записано в "cl"!!!!!
            BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);     // Так как это конструктор, 
                                                                                        // для его вызова не нужен объект типа (предпоследний аргумент null)

            t.InvokeMember(me,                                  // В этом блока мы вызываем метод того типа, который записан в "cl", 
            BindingFlags.DeclaredOnly |                         // а сам метод в "me" (первый аргумент)
            BindingFlags.Public | BindingFlags.NonPublic |      // Вызывается весь этот замес для объекта obj (предпоследний аргумент)
            BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, param);


        }
    }
}
