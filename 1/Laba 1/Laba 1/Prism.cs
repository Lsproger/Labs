using System;


namespace Laba_1
{
    class Prism
    {
        public static int numb;
        private double a, b, c, h;
        public Prism()
        {
            a = 1;
            b = 1;
            c = 1;
            h = 1;
            hash = key * a * a - (b * c) + h;
            numb++;
        }
        public Prism(double a, double b, double c, double h)
        {
            A = a;
            B = b;
            C = c;
            H = h;
            hash = key * a *a  - (b * c) + h;
            numb++; 
        }
        static Prism() { numb = 0; }
        public double A
          {
              get { return a; }
              set
              {
                  if (value < 0) throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater than 0");
                  a = value;
              }
          }
        public double B
          {
              get { return b; }
              set
              {
                  if (value < 0) throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater than 0");
                  b = value;
              }
          }
        public double C
          {
              get { return c; }
              set
              {
                  if (value < 0) throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater than 0");
                  c = value;
              }
          }
        public double H
          {
              get { return h; }
              set
              {
                if (value < 0) throw new ArgumentOutOfRangeException("value", value.ToString(), "The value must be greater than 0");
                h = value;
                return;
              }
          }
        private const double key = 7;
        private readonly double hash;
        public static void Info()
          {
              Console.WriteLine("Класс — призма;");
              Console.WriteLine("Количество экземпляров = " + numb);
          }
        public double IsSimilar(ref Prism x, out double k)
          {
              if (a / x.a == b / x.b &&
                  b / x.b == c / x.c &&
                  c / x.c == h / x.h)
              {
                  Console.WriteLine("Данные призмы пропорциоальны");
                  k = a / x.a;
                Console.Write("Коэффициент подобия = ");
              }
              else
              {
                  Console.WriteLine("Данные призмы не пропорциональны");
                  k = 0;
              }
              return k;
          }
          // override object.Equals
        public override bool Equals(object obj)
          {
            Prism p = obj as Prism;
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            if (a == p.a &&
              b == p.b &&
              c == p.c &&
              h == p.h &&
              hash == p.hash) return true;
            else return false;
          }
          // override object.GetHashCode
        public override int GetHashCode()
          {
              return (int)hash;
          } 
    }
}