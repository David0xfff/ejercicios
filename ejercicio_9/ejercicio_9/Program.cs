using System;

namespace ejercicio_9
{
    class Program
    {

        static void Main(string[] args)
        {

            //primer numero
            Console.WriteLine("Ingresar el primer numero entero positivo entre 100 y 500");
            int primer_num = int.Parse(Console.ReadLine());

            while (primer_num < 100 || primer_num > 500)
            {
                Console.WriteLine("Ingresar eL NUMERO CORRECTO");
                primer_num = int.Parse(Console.ReadLine());

            }
            //segundo numero 
            Console.WriteLine("Ingresar el segundo numero entero positivo entre 100 y 500");
            int segundo_num = int.Parse(Console.ReadLine());

            while (segundo_num < 100 || segundo_num > 500)
            {
                Console.WriteLine("Ingresar eL NUMERO CORRECTO");
                segundo_num = int.Parse(Console.ReadLine());

            }
            //tercer numero
            Console.WriteLine("Ingresar el tercer numero entero positivo entre 100 y 500");
            int tercer_num = int.Parse(Console.ReadLine());

            while (tercer_num < 100 || tercer_num > 500)
            {
                Console.WriteLine("Ingresar eL NUMERO CORRECTO");
                tercer_num = int.Parse(Console.ReadLine());
            }

            //cuarto numero 
            Console.WriteLine("Ingresar el primer cuarto entero positivo entre 100 y 500");
            int cuarto_num = int.Parse(Console.ReadLine());

            while (cuarto_num < 100 || cuarto_num > 500)
            {
                Console.WriteLine("Ingresar eL NUMERO CORRECTO");
                cuarto_num = int.Parse(Console.ReadLine());
            }
            //quinto numero
            Console.WriteLine("Ingresar el quinto numero entero positivo entre 100 y 500");
            int quinto_num = int.Parse(Console.ReadLine());

            while (quinto_num < 100 || quinto_num > 500)
            {
                Console.WriteLine("Ingresar eL NUMERO CORRECTO");
                quinto_num = int.Parse(Console.ReadLine());
            }

            int promedio = (primer_num + segundo_num + tercer_num + cuarto_num + quinto_num)/5;
            Console.WriteLine("el promedio es: " + promedio);

            int[] cad_numeros = { primer_num, segundo_num, tercer_num, cuarto_num, quinto_num };
            int menor = 0;
            int mayor = 0;
            int cercano = 0;


            for (int i = 0; i < cad_numeros.Length; i++)
            {
             if (cad_numeros[i] == promedio) { cercano = cad_numeros[i]; break; }
             if (cad_numeros[i] < promedio) { menor = cad_numeros[i]; }
             if (cad_numeros[i] > promedio) { mayor = cad_numeros[i]; }
            }

            if (mayor != 0 && menor != 0)
            {
                if ((mayor - promedio) < (promedio - menor)) { cercano = menor; }
                else { cercano = menor; }
            }

            Console.WriteLine("el numero mas cercano al promedio es: " + cercano );

        }
    }
}

