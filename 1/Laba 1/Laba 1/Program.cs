using System;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
             double k;      //Коэффициент подобия призм
             Prism pr1 = new Prism();
             Prism pr2 = new Prism(3, 3, 3, 3);
             Console.WriteLine(pr1.GetHashCode());
             Console.WriteLine(pr2.IsSimilar(ref pr1, out k));
             Prism.Info();
             if (pr1.Equals(pr2))
             {
                 Console.WriteLine("Призмы идентичны!!!");
             }
             else { Console.WriteLine("Не, соре, не идентичны)))"); }
             Prism pr3 = new Prism(3, 4, 5, 6);
             Console.WriteLine
                 ("Площадь поверхности призмы = "+
                 MathObject.SurfaceSquare(pr3));
             Console.WriteLine
                 ("Площадь основания = " +
                 MathObject.SquareOfBase(pr3));
             Console.WriteLine
                 ("Объём призмы = " +
                 MathObject.Amount(pr3)
                 );
             Box b = new Box(3, 4, 6);
            // Console.WriteLine(MathObject.TriangleCircleR(pr3) + "  " + MathObject.RectangleCircleR_AB(b));
             if (MathObject.IsCanBePlaced(pr3, b)) Console.WriteLine("Может быть помещена");
             else Console.WriteLine("Не может");
             var pr4 = new { a=5, b = 5, c=5, h = 6 };
             Console.WriteLine(pr4.a + " " + pr4.b + " " + pr4.c + " " + pr4.h + " ");
             Prism check = new Prism(1, 2, 3, 4); 
        }
    }
}