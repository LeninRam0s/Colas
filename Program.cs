using Colas.Clases.ColaArreglo;
using Colas.Clases.Ejemplos;
using Colas.Clases.Pila_Lista;
using System;
using System.Collections;

namespace Colas
{
    class Program
    {

        private static bool validacion(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char c;
                c = numero[i++];
                sw = (c >= '0' && c <= '9');
            }
            return sw;
        }



        static void Main(string[] args)
        {


            EjemploStackQueue ej = new();
            ej.CapicuaStackQueue();


        }
    }
}
