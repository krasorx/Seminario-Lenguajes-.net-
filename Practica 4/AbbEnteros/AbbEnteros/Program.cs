using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
/*
    9) Modelar un árbol binario de búsqueda de valores enteros(sin valores duplicados).
    Desarrollar los métodos métodos: 
    1.Insertar(valor) : Inserta valor en el árbol descartándolo en caso que ya exista. 
    2.RecorridoInorden: devuelve un vector con los valores ordenados en forma creciente.
    3.Altura: devuelve la altura del árbol.
    4.CantNodos: devuelve la cantidad de nodos que posee el árbol.
    5.ValorMáximo: devuelve el valor máximo que contiene el árbol.
    6.ValorMínimo:devuelve el valor mínimo que contiene el árbol
*/
namespace AbbEnteros
{
    public class Nodo
    {
        public int Data { get; set; }
        public Nodo Izq { get; set; }
        public Nodo Der { get; set; }
        public Nodo()
        {

        }
        public Nodo(int data)
        {
            this.Data = data;

        }
    }
    public class ArbolBinario
    {
        private Nodo _root;
        public ArbolBinario()
        {
            _root = null;
        }
        public void Insertar(int data)
        {
            // 1. Si el árbol esta vacio, devuelve un solo nodo nuevo 
            if (_root == null)
            {
                _root = new Nodo(data);
                return;
            }
            // 2. Caso contrario, recorre el arbol hacia abajo
            InsertarRec(_root, new Nodo(data));
        }
        private void InsertarRec(Nodo root, Nodo NewNodo)
        {
            if (root == null)
                root = NewNodo;

            if (NewNodo.Data < root.Data)
            {
                if (root.Izq == null)
                    root.Izq = NewNodo;
                else
                    InsertarRec(root.Izq, NewNodo);
                        
            }
            else if(NewNodo.Data > root.Data)
                {
                    if (root.Der == null)
                        root.Der = NewNodo;
                    else
                        InsertarRec(root.Der, NewNodo);
                }
                else
            {
                root = NewNodo;
            }
        }
        private void MostrarArbol(Nodo root)
        {
            if (root == null) return;

            MostrarArbol(root.Izq);
            System.Console.Write(root.Data + " ");
            MostrarArbol(root.Der);
        }
        public void MostrarArbol()
        {
            MostrarArbol(_root);
        }


        private void RecorridoInorden(Nodo root,ArrayList vector)
        {
            if (root == null) return;

            RecorridoInorden(root.Izq,vector);
            vector.Add(root.Data);
            RecorridoInorden(root.Der,vector);
            
        }
        public void RecorridoInorden(ArrayList vector)
        {
            RecorridoInorden(_root,vector);
        }
        public int CantNodos()
        {
            return CantNodos(_root);
        }
        private int CantNodos(Nodo root)
        {
            if (root == null)
                return 0;
            return 1 + CantNodos(root.Izq) + CantNodos(root.Der);
        }

        public int ValorMinimo()
        {
            return ValorMinimo(_root);
        }

        private int ValorMinimo(Nodo root)
        {
            if (root == null)
                return -1;
            else
            {
                Nodo Actual = root;
                while (Actual.Izq != null)
                {
                    Actual = Actual.Izq;
                }
                return Actual.Data;

            }
        }
        public int ValorMaximo()
        {
            return ValorMaximo(_root);

        }

        private int ValorMaximo(Nodo root)
        {
            if (_root == null)
                return -1;
            else
            {
                Nodo actual = root;
                while (actual.Der != null)
                {
                    actual = actual.Der;
                }
                return actual.Data;
            }
        }
        public int Altura()
        {
            return Altura(_root);
        }
        private int Altura(Nodo root)
        {
            if (root == null)
                return -1;
            else
            {
                int alturaIzq = Altura(root.Izq);
                int alturaDer = Altura(root.Der);
                //Devuelve la altura maxima de una de las hojas
                return 1 + Math.Max(alturaIzq, alturaDer);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            Nodo root = new Nodo();
            
            ArrayList vector = new ArrayList();

            arbol.Insertar(4);
            arbol.Insertar(2);
            arbol.Insertar(5);
            arbol.Insertar(1);
            arbol.Insertar(3);
            arbol.Insertar(4);
            arbol.Insertar(1);
            arbol.MostrarArbol();

            Console.WriteLine("\nNodos = {0} ",arbol.CantNodos());
            Console.WriteLine("Altura = {0} ", arbol.Altura());
            
            
            arbol.RecorridoInorden(vector);

            Console.WriteLine("Imprimir ordenado : ");
            for (int j = 0; j < vector.Count; j++)
            {
                Console.Write("|{0}|",vector[j]);
            }

            Console.ReadKey();
        }
    }
}
