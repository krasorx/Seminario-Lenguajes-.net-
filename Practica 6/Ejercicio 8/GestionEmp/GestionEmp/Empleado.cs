using System;
using System.Collections.Generic;
using System.Text;

namespace GestionEmp
{
    class Empleado
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
            return 0.0;
        }
    }

    class Administrativo : Empleado
    {
        private double premio;

        public Administrativo() : base( nombre,  dni, fechaDeIngreso,  salarioBase)
        {

        }

        public double Premio { get => premio; set => premio = value; }

        protected override double CalcularSalario()
        {
            return base.CalcularSalario() + (Premio);
        }
    }

    class Vendedor : Empleado
    {
        private double comision;

        public Vendedor() : base(string nombre, int dni, DateTime fechaDeIngreso, double salarioBase)
        {

        }

        public double Comision { get => comision; set => comision = value; }

        protected override double CalcularSalario()
        {
            return base.CalcularSalario() + Comision;
        }
    }

}
