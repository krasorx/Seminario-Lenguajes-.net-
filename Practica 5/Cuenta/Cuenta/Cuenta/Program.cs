using System;

namespace Cuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta();
            Cuenta c2 = new Cuenta();
            c1.Depositar(100);
            c2.Depositar(200);
            c1.Depositar(200);
            c2.Retirar(50);
            Cuenta.ImprimirDetalle();



            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
