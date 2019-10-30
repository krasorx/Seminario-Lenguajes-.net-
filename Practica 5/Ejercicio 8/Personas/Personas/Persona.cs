using System;
using System.Collections.Generic;
using System.Text;

namespace Personas
{
    class Persona
    {
        private string nombre;
        private int sexo;   // 1 hombre, 2 mujer.
        private int dni;
        private DateTime fechaNacimiento;
        private int edad;

        public string this[int i]
        {
            get
            {
                if (i == 1)
                    return ( (Sexo == 1) ? ("Hombre") : ("Mujer") );
                else
                    if (i == 2)
                    return DNI.ToString();
                    else
                        if(i == 3)
                            return FechaNacimiento.ToShortTimeString();
                        else
                            if(i == 4)
                        {
                                return Edad.ToString();
                        }
                return "Indice invalido";
            }
            set
            {
                if (i == 1)
                    Sexo = ((Sexo == 1) ? (1) : (2));
                else
                    if (i == 2)
                    DNI = (Convert.ToInt32(value));
                else
                        if (i == 3)
                    FechaNacimiento = Convert.ToDateTime(value);
                // no se puede asignar edad. se calcula.
            }
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public int DNI { get => dni; set => dni = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public int Edad
        {
            get => (DateTime.Now.Year - fechaNacimiento.Year);  // deberia tener en cuenta la fecha entera...
        }

    }
}
