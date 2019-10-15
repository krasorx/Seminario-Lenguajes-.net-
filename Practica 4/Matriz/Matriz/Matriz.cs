using System;
using System.Collections.Generic;
using System.Text;

namespace Matriz
{
    class Matriz
    {
        private int filas;
        private int columnas;
        private double[,] matriz;

        public Matriz(int filas, int columnas)
        {
            this.matriz = new double[filas, columnas];
        }
        public Matriz(double[,] matriz)
        {
            this.matriz = matriz;
        }
        public void SetElemento(int fila, int columna, double elemento)
        {
            this.matriz[fila, columna] = elemento;
        }
        public double GetElemento(int fila, int columna)
        {
            return this.matriz[fila, columna];
        }
        public void imprimir()
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    Console.Write(this.matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void imprimir(string formatString)
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    Console.Write("{0:" + formatString + "}" + " ", this.matriz[i, j]);
                }
                Console.WriteLine();
            }
        }


        public double[] GetFila(int fila)
        {
            double[] v = new double[this.matriz.GetLength(fila)];
            for (int i = 0; i < this.matriz.GetLength(fila); i++)
            {
                v[i] = this.matriz[fila, i];
            }
            return v;
        }


        public double[] GetColumna(int columna)
        {
            double[] v = new double[this.matriz.GetLength(columna)];
            for (int i = 0; i < this.matriz.GetLength(columna); i++)
            {
                v[i] = this.matriz[i, columna];
            }
            return v;
        }


        public double[] GetDiagonalPrincipal()
        {
            if (this.matriz.GetLength(0) != this.matriz.GetLength(1))
            {
                return null;
            }
            else
            {
                double[] v = new double[this.matriz.GetLength(0)];
                for (int i = 0; i < this.matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < this.matriz.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            v[i] = this.matriz[i, j];
                        }
                    }
                }

                return v;
            }
        }

        public double[] GetDiagonalSecundaria()
        {
            if (this.matriz.GetLength(0) != this.matriz.GetLength(1))
            {
                return null;
            }
            else
            {
                double[] v = new double[this.matriz.GetLength(0)];
                for (int i = 0; i < this.matriz.GetLength(0); i++)
                {
                    for (int j = this.matriz.GetLength(0) - 1; j >= 0; j--)
                    {
                        if (i + j == this.matriz.GetLength(0) - 1)
                        {
                            v[i] = this.matriz[i, j];
                        }
                    }
                }

                return v;
            }
        }


        public void multiplicarPor(Matriz m)
        {
            double total;
            Matriz matriz_aux = new Matriz(this.matriz.GetLength(0), this.matriz.GetLength(1));
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    total = 0;
                    for (int k = 0; k < this.matriz.GetLength(1); k++)
                    {
                        total = total + (this.matriz[i, k] * m.matriz[k, j]);
                    }
                    matriz_aux.matriz[i, j] = total;
                }
            }
            this.matriz = matriz_aux.matriz;
        }


        public void sumarle(Matriz m)
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    this.matriz[i, j] += m.matriz[i, j];
                }
            }
        }
        public void restarle(Matriz m)
        {
            for (int i = 0; i < this.matriz.GetLength(0); i++)
            {
                for (int j = 0; j < this.matriz.GetLength(1); j++)
                {
                    this.matriz[i, j] -= m.matriz[i, j];
                }
            }
        }


    }
}
