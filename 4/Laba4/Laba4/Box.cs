using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public class Box : IComparable, IEnumerable
    {
        public delegate string Str(Box b);
        public Box(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        private double a, b, c;
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }
        public int CompareTo(object obj)
        {
            return new Int32();
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public Str ToStr = x => "Volume of this box = " + x.A * x.B * x.C +"\n";
        public override string ToString()
        {
            return ToStr(this);
        }
        private int volume;
        public int Volume
        {
            get { return (int)(A * B * C); }
            set { }
        }
        public int Volume1()
        {
            return (int)(A * B * C);
        }
    }
}
