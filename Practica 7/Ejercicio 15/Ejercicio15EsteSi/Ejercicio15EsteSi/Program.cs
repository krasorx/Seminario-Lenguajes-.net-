﻿using System;

delegate void Accion();   //leer?

class Program
{
    public static void Main()
    {
        Palabras pal = new Palabras();
        pal.Contar();
        Console.ReadKey();
    }

    public static void contarPalabras()
    {
        
    }

}
class Palabras
{
    public Accion contarPalabras;
    private int cantPalabras = 0;

    public void Contar()
    {
        Lector miLector = new Lector();
        contarPalabras = unaMas;
        miLector.Leer(contarPalabras);
        Console.WriteLine("Cantidad de palabras leídas: {0}", cantPalabras);
    }
    private void unaMas()
    {
        cantPalabras++;
    }

}
class Lector
{
    public Palabras padre;
    public void Leer(Action action)
    {
        Console.WriteLine("Ingrese una palabra por línea");
        string st = Console.ReadLine();
        while (st != "")
        {
            action?.Invoke();
            st = Console.ReadLine();
        }
    }
}
