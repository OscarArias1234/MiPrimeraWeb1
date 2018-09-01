using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPrimeraWeb1
{
    public class calculadora
    {
        static void Main(string[] args)
        {

            int opcion;
            string cadena = "Super Calculadora";
            cadena = cadena + "\n 1. Suma";
            cadena = cadena + "\n 2. Resta";
            cadena = cadena + "\n 3. Multiplica";
            cadena = cadena + "\n 4. Divide";
            cadena = cadena + "\n 5. Salir";
            cadena = cadena + "\n Digite su opcion";

            do
            {
                Console.WriteLine(cadena);
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion >= 1 && opcion <= 4)
                {
                    calcular(opcion);
                    Console.Clear();
                }
            } while (opcion != 5);
        }

        private static void calcular(int opcion)
        {
            Console.WriteLine("Digite el primer valor");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor");
            int val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" " + mostrar(val1, val2, opcion));
            Console.ReadKey();
        }

        private static int mostrar(int val1, int val2, int opcion)
        {
            int resultado = 0;
            if (opcion == 1)
            {
                resultado = val1 + val2;
            }
            if (opcion == 2)
            {
                resultado = val1 - val2;
            }
            if (opcion == 3)
            {
                resultado = val1 * val2;
            }
            if (opcion == 4)
            {
                if (val2 > 0)
                {
                    resultado = val1 / val2;
                }
            }
            return resultado;
        }
    }
}
