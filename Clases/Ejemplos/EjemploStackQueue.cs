using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Ejemplos
{
    class EjemploStackQueue
    {
        public bool validacion(String numero)
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

        public void CapicuaStackQueue()
        {
            bool capicua;
            String numero;
            Stack<Char> pila = new Stack<char>();
            Queue<Char> cola = new Queue<char>();

            try
            {
                capicua = false;

                do
                {
                    Console.WriteLine("\nIngrese un numero: ");
                    numero = Console.ReadLine();
                } while (!validacion(numero));

                //EL DIGITO SE COLOCA EN LA COLA Y EN LA PILA 
                for (int i = 0; i < numero.Length; i++)
                {
                    char c;
                    c = numero[i];
                    pila.Push(c);//AGREGA PILA
                    cola.Enqueue(c);//AGREGA COLA
                }
                //EXTRAER EL DIGITO DE LA COLA Y DE LA PILA PARA EVALUAR
                do
                {
                    char d;
                    d = cola.Dequeue();
                    capicua = d.Equals(pila.Pop());
                } while (capicua && cola.Count != 0);

                if (capicua)
                {
                    Console.WriteLine($"\nNumero {numero} es capicua");
                }
                else
                {
                    Console.WriteLine($"\nNumero {numero} no es capicua");
                    Console.WriteLine("\n*INTENTE DE NUEVO*");
                    new EjemploStackQueue().CapicuaStackQueue();
                }
                //LIMPIAR ESTRUCTURAS
                pila = new Stack<char>();
                cola = new Queue<char>();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
