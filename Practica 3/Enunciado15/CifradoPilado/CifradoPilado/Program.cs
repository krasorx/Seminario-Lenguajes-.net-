using System;
using System.Collections;

namespace CifradoPilado
{
    //15.
    //Utilice la  clase queue(cola)  para implementar  un programa que
    //realice  el cifrado  de un  texto aplicando  la técnica  de clave
    //repetitiva.La técnica  de clave  repetitiva consiste  en desplazar
    //un carácter una cantidad constante de acuerdo a la lista de valores
    //que se encuentra en la clave.
    //A cada carácter del mensaje original se le suma la cantidad indicada
    //en la clave.En el caso que la suma  fuese mayor  que  28  se debe  
    //volver a  contar desde  el principio, Tenga  en cuenta  que para 
    //resolver este  problema debe  utilizar una  cola que  guarde la  clave
    //y  que a  medida que  saque elementos  de la  cola los  tiene que 
    //agregar nuevamente  para poder  utilizarla en  forma repetitiva.
    //Programe una rutina para cifrar y otra para descifrar.

    class Program
    {
        static void Main(string[] args)
        {

            Queue cola = new Queue();
            String msj;
            String clave;
            int colaFirst;
            int dif;

            int[] codigo;

            int i = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            //begin

            Console.Write("Ingresar el mensaje a cifrar : ");
            msj = Console.ReadLine();
            Console.Write("Ingresar la clave de cifrado : ");
            clave = Console.ReadLine();
            dif = (msj.Length % clave.Length);

            int length = msj.Length;
            int cLength = clave.Length;

            codigo = new int[length];   // crea el vector de codigo
            msj = msj.ToUpper();
            Codificar(msj,codigo);

            //Armamos la cola
            foreach(char c in clave)
            {
                cola.Enqueue(Convert.ToInt32(c));
            }

            // codigo sin cifrar
            Console.Write("Mensaje codificado : ");
            for (int k = 0; k < codigo.Length; k++)
            {
                Console.Write("{0} ", codigo[k]);
            }
            Console.WriteLine();

            // cifrado
            CifrarMensaje(codigo, cola);

            // imprimir mensaje cifrado
            Console.Write("Codigo cifrado : ");
            for (int j = 0; j < codigo.Length; j++)
            {
                Console.Write(" {0} ", codigo[j]);
            }
            Console.WriteLine();

            while(dif > 0)
            {
                var a = cola.Dequeue();
                cola.Enqueue(a);
                dif--;
            }

            DescifrarMensaje(codigo, cola);
            Console.Write("Codigo decifrado : ");
            for (int j = 0; j < codigo.Length; j++)
            {
                Console.Write(" {0} ", codigo[j]);
            }
            // imprimir mensaje descifrado

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }



        private static void CifrarMensaje(int[] vector, Queue q)
        {
            int x;
            int qBuffer;
            for (int i = 0; i < vector.Length; i++) 
            {
                qBuffer = Convert.ToInt32(q.Dequeue()) - 48;
                x = vector[i] + qBuffer;
                q.Enqueue(qBuffer + 48);
                if(x > 27)
                    x = (x - 27);
                vector[i] = x;      
            }  
        }

        private static string DescifrarMensaje(int[] vector, Queue q)
        {
            string msj = "";
            int x;
            int qBuffer;
            for (int i = 0; i < vector.Length; i++)
            {
                qBuffer = Convert.ToInt32(q.Dequeue()) - 48;
                x = vector[i] - qBuffer;
                q.Enqueue(qBuffer + 48);
                if (x > 27)
                    x = (x - 27);
                else
                    if (x < 0)
                    x = (27 - x);
                vector[i] = x; 
            }
            return msj;
        }

        //Convierte al mensaje en una serie de numeros
        private static void Codificar(string msj,int[] vector) 
        {
            // a = 65 --> 1
            // space = 32 --> 27 end   | no uso ñ
            // delta = 64

            int delta = 64;
            int n = 1;


            for (int i = 0; i < msj.Length; i++)
            {
                
                if( (msj[i] > 64) && (msj[i] < 91) )   // Verifica que es una letra
                {
                    vector[i] = (msj[i] - delta);
                }
                else
                    if(msj[i] == (32))  // verifica si es el espacio
                        vector[i] = 27;
            }

        }
    }
}
