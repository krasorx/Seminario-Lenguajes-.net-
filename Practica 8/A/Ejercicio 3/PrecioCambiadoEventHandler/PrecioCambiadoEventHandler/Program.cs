using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Defina  el  delegado PrecioCambiadoEventHandler,  la  clase PrecioCambiadoEventArgs
 * y  la clase Articulo de tal forma que el programa siguiente genere la salida por 
 * consola que se muestra en la figura 1    
 * 
 */
delegate void PrecioCambiadoEventHandler(object sender, PrecioCambiadoEventArgs e);
class PrecioCambiadoEventArgs : EventArgs
{
    public double Codigo { get; set; }
    public double PrecioAnterior { get; set; }
    public double PrecioNuevo { get; set; }
}
namespace PrecioCambiado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Articulo a = new Articulo();
            a.precioCambiado += new PrecioCambiadoEventHandler(precioCambiado);
            a.Codigo = 1;
            a.Precio = 10;
            a.Precio = 12;
            a.Precio = 12;
            a.Precio = 14;
            Console.ReadKey(true);
        }
        public static void precioCambiado(object sender, PrecioCambiadoEventArgs e)
        {
            string texto = "Artículo {0} valía {1} y ahora vale {2}";
            Console.WriteLine(texto, e.Codigo, e.PrecioAnterior, e.PrecioNuevo);
        }
    }
    class Articulo
    {
        public PrecioCambiadoEventHandler precioCambiado;
        private double precio;
        private double precioOld;
        private double precioNew;
        private int codigo;

        public double Precio { get => precio; set => PreciosCambiados(value, Precio); }
        public int Codigo { get => codigo; set => codigo = value; }
        public double PrecioOld { get => precioOld; private set => precioOld = value; }
        public double PrecioNew { get => precioNew; private set => precioNew = value; }

        public void PreciosCambiados(double newPrice,double oldPrice)
        {
            
            this.precio = newPrice;
            if (precioCambiado != null)
                precioCambiado(this, new PrecioCambiadoEventArgs() { Codigo = Codigo, PrecioAnterior = oldPrice, PrecioNuevo = newPrice });

        }

    }

}
