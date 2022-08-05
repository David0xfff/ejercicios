using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, num, a, b, Rf, R, P, e, c;

            Console.WriteLine("Digite el nombre del primer numero del rango");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite el nombre del segundo numero del rango");
            m = int.Parse(Console.ReadLine());
         

            for (n = n + 1; n < m; n++)
            {
                a = n;
                b = n;
                Rf = 0;
                P = 0;

                while (a > 0)
                {
                    num = a % 10;
                    a = a / 10;
                    P = P + 1;
                }
                P = P - 1;
                while (b > 0)
                {
                    c = b % 10;
                    b = b / 10;
                    e = (int)Math.Pow(10, P);
                    R = c * e;
                    Rf = Rf + R;
                    P = P - 1;
                }
                if (Rf == n)
                    Console.WriteLine("El numero " + n + " es capicua");
            }        
        }
    }
}
