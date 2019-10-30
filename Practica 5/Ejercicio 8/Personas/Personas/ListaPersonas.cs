using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Personas
{
    class ListaPersonas
    {
        private ArrayList lista = new ArrayList();

        public void AgregarPersona(Persona p)
        {
            lista.Add(p);
        }

        public Persona this[int dni]  // documento solo lectura a)
        {
            get
            {
                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (((Persona)lista[i]).DNI == dni)
                            return (Persona)lista[i];   // si lo encontró lo devuelve
                    }
                    return null;    // recorrio toda la lista y no encontró nada
                }
                else
                    return null;    // lista vacia
                    
            }
        }
        public Persona this[char c]  // documento solo lectura b)
        {
            get
            {
                if (lista.Count > 0)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        if (((Persona)lista[i]).Nombre[1].Equals(c))
                            return (Persona)lista[i];   // si lo encontró lo devuelve
                    }
                    return null;    // recorrio toda la lista y no encontró nada
                }
                else
                    return null;    // lista vacia

            }
        }

    }
}
