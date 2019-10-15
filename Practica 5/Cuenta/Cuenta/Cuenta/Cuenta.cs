using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Cuenta
{
    class Cuenta
    {
        private static ArrayList arl = new ArrayList();
        private static double montoTotalCuentas;
        private double monto;
        private int titularDNI;
        private string titularNombre;
        private static int cuentas;
        

        public Cuenta()
        {
            this.monto = 0;
            this.titularDNI = 0;
            this.titularNombre = "No especificado";
            cuentas++;
            arl.Add(this);
        }
        public Cuenta(int dni)
        {
            this.titularDNI = dni;
            this.titularNombre = "No especificado";
            this.monto = 0;
            cuentas++;
            arl.Add(this);
        }
        public Cuenta(string nombre)
        {
            this.titularNombre = nombre;
            this.titularDNI = 0;
            this.monto = 0;
            cuentas++;
            arl.Add(this);
        }
        public Cuenta(string nombre, int dni)
        {
            this.titularNombre = nombre;
            this.titularDNI = dni;
            this.monto = 0;
            cuentas++;
            arl.Add(this);
        }
        public Cuenta this[int i]
        {
            get
            {
                return this[i];
            }
            set
            {
                this[i] = value;
            }
        }

        public void Depositar(double monto)
        {
            this.monto += monto;
            montoTotalCuentas += monto;
        }
        
        public void Retirar(double monto)
        {
            if (monto < this.monto)
            {
                this.monto -= monto;
                montoTotalCuentas -= monto;
            }
            else
                Console.WriteLine("Operación cancelada, monto insuficiente.");
        }

        

        public static ArrayList GetCuentas()
        {

            return arl;
        }

        public void Imprimir()
        {
            Console.Write("Nombre: {0}, DNI: ", titularNombre);
            if (titularDNI > 0)
                Console.Write("{0}",titularDNI);
            else
                Console.Write("No especificado");
            Console.WriteLine(", Monto: {0}",monto);
        }

        public static void ImprimirDetalle()
        {
            Console.WriteLine("Se instanciaron {0} cuentas",cuentas);
            Console.WriteLine("El monto total de las cuentas suma : {0}",montoTotalCuentas);
        }

    }
}
