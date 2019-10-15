using System;

// 10)Implemente la clase Matrizque se utilizará para trabajar con matrices matemáticas

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz A = new Matriz(2, 3);
            for (int i = 0; i < 6; i++)
                A.SetElemento(i / 3, i % 3, (i + 1) / 3.0);
            Console.WriteLine("Impresión de la matriz A");
            A.imprimir("0.000");
            double[,] aux = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matriz B = new Matriz(aux);
            Console.WriteLine("\nImpresión de la matriz B");
            B.imprimir();
            Console.WriteLine("\nAcceso al elemento B[1,2]={0}", B.GetElemento(1, 2));
            Console.Write("\nfila 1 de A: ");
            foreach (double d in A.GetFila(1))
                Console.Write("{0:0.0} ", d);
            Console.Write("\n\nColumna 0 de B: ");
            foreach (double d in B.GetColumna(0))
                Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal principal de B: ");
            foreach (double d in B.GetDiagonalPrincipal())
                Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal secundaria de B: ");
            foreach (double d in B.GetDiagonalSecundaria())
                Console.Write("{0} ", d); A.multiplicarPor(B);
            Console.WriteLine("\n\nA multiplicado por B");
            A.imprimir();
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
