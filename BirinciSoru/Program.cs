using System;

namespace BirinciSoru
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bu program iki değişkenli iki denklemden oluşan bir doğru denklem sisteminin kesişim noktasını bulur.\n\n");
            double a1, b1, m1, a2, b2, m2;
            double[] intersectPoint = new double[2];
            Console.Write("A1 değerini giriniz :");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B1 değerini giriniz :");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("M1 değerini giriniz :");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("A2 değerini giriniz :");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B2 değerini giriniz :");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("M2 değerini giriniz :");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\nBirinci denklem : ({0}x)+({1}y)={2}\n\n", a1,b1,m1);
            Console.WriteLine("\n\nİkinci denklem : ({0}x)+({1}y)={2}\n\n", a2, b2, m2);
            FindIntersect(a1, b1, m1, a2, b2, m2, intersectPoint);

        }
        static void FindIntersect(double a1, double b1, double m1, double a2, double b2, double m2, double[] intersectPoint)
        {
            double xValue = (((b2 * m1) - (b1 * m2)) / ((b2 * a1) - (b1 * a2)));
            double yValue = ((m1 - (a1 * xValue)) / (b1));
            intersectPoint[0] = xValue;
            intersectPoint[1] = yValue;
            Console.WriteLine("X Değeri : " + xValue);
            Console.WriteLine("Y Değeri : " + yValue);
        }
    }
}
