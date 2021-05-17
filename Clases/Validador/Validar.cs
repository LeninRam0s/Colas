using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Validador
{
    class Validar
    {
        public static int esNUMERO(string n)
        {
            int valor;
            bool esNumero;
            do
            {
                //n = Console.ReadLine();
                /* Si es número correcto retornará true y saldrá
                  *  del Ciclo*/
                Console.WriteLine("Ingrese un entero");
                esNumero = int.TryParse(n, out valor);
               // Console.WriteLine(valor+" No es numero");
                //return valor;

            } while (!esNumero);
            Console.WriteLine(n + " Es numero");
            return valor;
            

                

                //esNumero = int.TryParse(n, out valor);
            //while (!esNumero)
            //{
            //    Console.WriteLine("El valor ingresado no es un numero");
            //    return 0;
            //}
            //Console.WriteLine("El valor es:"+valor);
            //return valor;

            
            
            
        }
    }
}
