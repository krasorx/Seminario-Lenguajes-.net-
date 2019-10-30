using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmp
{
    public class Empleado
    {
        private string nombre;
        private int dni;
        private DateTime fechaDeIngreso;
        private double salarioBase;
        private double salario;

        public string Nombre { get => nombre; protected set => nombre = value; }
        public int DNI { get => dni; protected set => dni = value; }
        public DateTime FechaDeIngreso { get => fechaDeIngreso; protected set => fechaDeIngreso = value; }
        public double SalarioBase { get => salarioBase; protected set => salarioBase = value; }
        public double Salario { get => CalcularSalario(); }

        public Empleado(string nombre,int dni, DateTime fechaDeIngreso, double salarioBase)
        {
            Nombre = nombre;
            DNI = dni;
            FechaDeIngreso = fechaDeIngreso;
            SalarioBase = salarioBase;

        }

        protected virtual double CalcularSalario()
        {
            return this.salario;
        }

        public virtual void AumentarSalario()
        {
            
        }

    }

    public class Administrativo : Empleado
    {
        private double premio;

        public Administrativo(string nombre, int dni,DateTime fechaDeIngreso, double salarioBase, double premio) : base( nombre,  dni, fechaDeIngreso,  salarioBase)
        {
            Premio = premio;
        }

        public double Premio { get => premio; set => premio = value; }

        protected override double CalcularSalario()
        {
            return (base.CalcularSalario() + (Premio));
        }

        public override void AumentarSalario()
        {
            int antiguedad = DateTime.Now.Year - base.FechaDeIngreso.Year;
            SalarioBase += (antiguedad*(SalarioBase / 100)); // le sumo un 1% por cada año de antiguedad
        }

    }

    public class Vendedor : Empleado
    {
        private double comision;

        public Vendedor(string nombre, int dni, DateTime fechaDeIngreso, double salarioBase,double comision) : base( nombre,  dni, fechaDeIngreso, salarioBase)
        {
            Comision = comision;
        }

        public double Comision { get => comision; set => comision = value; }

        protected override double CalcularSalario()
        {
            return (base.CalcularSalario() + Comision);
        }

        public override void AumentarSalario()
        {
            int antiguedad = DateTime.Now.Year - base.FechaDeIngreso.Year;
            int a;
            if (antiguedad < 10)
                a = 5;
            else
                a = 10;

            SalarioBase += (antiguedad * ((a * SalarioBase) / 100));
        }
    }

}
