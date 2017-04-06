using System;

namespace Calculator
{
    class Calculator
    {
        private bool yesno = true;
        private double result, result1, result2;
        private char[] dd1 = new char[10];
        private char[] dd2 = new char[10];
        public string Calculate(string str)
        {
            string s1 = null;
            string s2 = null;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '+' || str[i] == '-' || str[i] == '*' || str[i] == '/')
                {
                    if (i != str.Length - 2)
                    {
                        str.CopyTo(0, dd1, 0, i);
                        s1 = new string(dd1);
                        result1 = Convert.ToDouble(s1);
                        str.CopyTo(i + 1, dd2, 0, str.Length - (i + 2));
                        s2 = new string(dd2);
                        result2 = Convert.ToDouble(s2);
                        if (str[i] == '+')
                            result = result1 + result2;
                        else if (str[i] == '-')
                            result = result1 - result2;
                        else if (str[i] == '*')
                            result = result1 * result2;
                        else if (str[i] == '/')
                            result = result1 / result2;
                        break;
                    }
                    else return ("   "+new Exception("Шо ты робiш?").ToString());
                }
            }
            return Convert.ToString(result);
        }
        public static string Sqrt(string str)
        {
            double result1 = Convert.ToDouble(str);
            double result = Math.Sqrt(result1);
            if (result >= 0) return Convert.ToString(result);
            else return new Exception("Отрицательное значени!!").ToString();
        }
        public static string Sin(string str)
        {
            double result1 = Convert.ToDouble(str);
            double result = Math.Sin(result1);
            return Convert.ToString(result);
        }
        public static string Cos(string str)
        {
            double result1 = Convert.ToDouble(str);
            double result = Math.Cos(result1);
            return Convert.ToString(result);
        }
    }
}
