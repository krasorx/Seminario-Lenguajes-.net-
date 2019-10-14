using System;
using System.Collections;

   // Utilice la clase Stack(pila) para implementar un programa que
   // pase un número en base 10 a otra base  realizando divisiones
   // sucesivas.Por ejemplo  para pasar  35  en  base  10  a binario
   // dividimos sucesivamente  por dos  hasta encontrar  un cociente
   // menor que  el divisor, luego  el resultado  se obtiene  leyendo
   // de  abajo hacia  arriba el  cociente de  la última  división 
   // seguida  por todos  los restos.

namespace StackSistNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;      // base del sistema de numeración. Número de símbolos permitidos en el sistema.
            int n;      // número en decimal.

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write("Ingresar un numero es decimal : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresar la base del sistema de numeración : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Numero {0} en base {1}, es = {2} ", n, b, (ConvertirBase(n, b)));

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Presione cualquier tecla para finalizar...");

            Console.ReadKey();
        }

        public static int ConvertirBase(int n, int b)
        {
            int x = Math.Abs(n);
            int c = 0; // cociente

            if (n == 0)
                return 0;   // 0 es 0 en toda base
            else
                if (b <= 0)
                    return -1;  // Base invalida

            Stack resultado = new Stack();  // Creamos la pila

            while(x > 0)
            {
                // c = x % b;  // los apilo en una stack
                resultado.Push(c = x % b);
                x = x / b;
            }

            // armo el numero desapilando la stack
            // 1) Desapilo
            // 2) Guardo en N
            // 3) Desapilo 
            // 4) Multiplico N por 10 y sumo lo desapilado
            // Wha- repito hasta que la stack este vacia 

            int a = 0;  // 0*0 = 0, la primera vez se mantiene en la unidad
            while (resultado.Count > 0)  // mientras haya objetos en la pila
            {
                a = (a*10) + (Convert.ToInt32(resultado.Pop()));
            }

            return a;
        }

    }
}
