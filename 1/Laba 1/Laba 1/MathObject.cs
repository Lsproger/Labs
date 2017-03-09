using System;
namespace Laba_1
{
    static class MathObject
    {
        public static double SquareOfBase(Prism p)
        {
            double hop = HalfOfPerim(p);
            return Math.Sqrt(hop * (hop - p.A) * (hop - p.B) * (hop - p.C));
        }
        private static double HalfOfPerim(Prism p)
        {
            return ((p.A + p.B + p.C) / 2);
        }
        public static double Amount(Prism p)
        {
            return (SquareOfBase(p) * p.H);
        }
        public static double AVerge(Prism p)
        {
            return p.A * p.H;
        }
        public static double BVerge(Prism p)
        {
            return p.B * p.H;
        }
        public static double CVerge(Prism p)
        {
            return p.C * p.H;
        }
        public static double SurfaceSquare(Prism p)
        {
            return (2 * SquareOfBase(p) + AVerge(p) + BVerge(p) + CVerge(p));
        }
        private static double HeightOnA(Prism p)
        {
            return (2 * SquareOfBase(p) / p.A);
        }
        private static double HeightOnB(Prism p)
        {
            return (2 * SquareOfBase(p) / p.B);
        }
        private static double HeightOnC(Prism p)
        {
            return (2 * SquareOfBase(p) / p.C);
        }
        public static double TriangleCircleR(Prism p)
        {
            return ((p.A * p.B * p.C) / (4 * SquareOfBase(p)));
        }
        public static double RectangleCircleR_AB(Box b)
        {
            return (Math.Sqrt(b.A*b.A + b.B*b.B)/2);
        }
        public static double RectangleCircleR_AC(Box b)
        {
            return (Math.Sqrt(b.A* b.A + b.C* b.C) /2);
        }
        public static double RectangleCircleR_BC(Box b)
        {
            return (Math.Sqrt(b.B* b.B + b.C*b.C) /2);
        }
        public static bool IsCanBePlaced(Prism p, Box b)
        {
            if (TriangleCircleR(p) <= RectangleCircleR_AB(b) && p.H <= b.C ||
                TriangleCircleR(p) <= RectangleCircleR_AC(b) && p.H <= b.B ||
                TriangleCircleR(p) <= RectangleCircleR_BC(b) && p.H <= b.A)
                return true;
            else return false;
        }
    }
}