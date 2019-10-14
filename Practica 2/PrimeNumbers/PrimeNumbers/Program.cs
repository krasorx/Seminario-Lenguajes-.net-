using System;

    //Escriba un programa que muestre todos los números primos entre 1 y un número dado.

    // Para ello diseñe  una función bool EsPrimo  (int n) que  indique si nes primo  o no. 

    // Esta función comprobará si n es divisible por algún número entero entre 2 y la raíz cuadrada de n.

    //     (Nota: para calcular la raiz cuadrada utilice Math.sqrt()

    // FINALIZADO

namespace PrimeNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Se mostraran los numeros primos desde 1 hasta el numero que ingrese : ");
            int centinela = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (int i=2;i<=centinela;i++)
            {
                if ((i % 10) == 0)
                {
                    Console.WriteLine();
                }
                if (EsPrimo(i))
                {
                    Console.Write(i);
                    Console.Write(" | ");

                }
            }

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
            
        }

        private static bool EsPrimo(int n)
        {
            double raiz = Math.Sqrt(n);
            int rz = Convert.ToInt32(Math.Round(raiz)); 
            int c = 2;
            while (c <= rz)
            {
                if ((n % c) == 0)
                {
                    return false;
                }
                c++;
            }
            return true;
        }
    }

}
