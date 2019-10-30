using System;
/*
*8) Defina la clase Personacon las siguientes propiedades de lectura y escritura:
*   Nombre, Sexo, DNI, FechaNacimiento.
* Además defina  una propiedad  de sólo  lectura(calculada) Edad.Defina un indizador
* de lectura/escritura que permita acceder a las propiedades a través de un índice entero.
* Así, si pes  un objeto Persona,  con p[0]se accede  al nombre, p[1]al sexo p[2] al  DNI,
* p[3] a  la fecha de nacimiento y p[4]a la edad.En caso de asignar p[4] simplemente el valor
* es descartado.
*/

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
