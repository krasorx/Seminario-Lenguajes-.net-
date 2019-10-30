using System;

namespace GestionEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[10];
            Console.ForegroundColor = ConsoleColor.Green;
            empleados[0] = new Administrativo("Joseph", 30666888, new DateTime(2008, 5, 23), 25000, 735.9);
            empleados[1] = new Administrativo("Ricardo", 40777555, new DateTime(2008,5,23), 23000,1300);
            empleados[2] = new Administrativo("Prosciuto", 35772158, new DateTime(2008, 5, 23), 15000, 250);
            empleados[3] = new Administrativo("Pimienta", 31415926, new DateTime(2014, 5, 23), 10000, 3.1416);

            empleados[4] = new Vendedor("Steely Dan",  38401328, new DateTime(2008, 6, 3), 6000, 16.3);
            empleados[5] = new Vendedor("Arabia Fats", 44555666, new DateTime(2014, 4, 3), 5000.10, 10);
            empleados[6] = new Vendedor("Dire",        35942152, new DateTime(2015, 2, 5), 3000.99, 0.5);
            empleados[7] = new Vendedor("Straits",     41987222, new DateTime(2015, 6, 23), 5333.33, 25.3);
            empleados[8] = new Vendedor("Maria",       37158926, new DateTime(2016, 5, 23), 8510, 2.5);
            empleados[9] = new Vendedor("Angelo",      35815926, new DateTime(2017, 6, 27), 2000, 0);




            foreach (Empleado e in empleados)
            {
                Console.WriteLine(e.Salario);
                e.AumentarSalario();
                Console.WriteLine(e.Salario);
            }

            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
