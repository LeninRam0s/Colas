using Colas.Clases.ColaArreglo;
using Colas.Clases.Ejemplos;
using Colas.Clases.Pila_Lista;
using Colas.Clases.Validador;
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
            // Console.WriteLine("Hello World!");

            //Stack s = new Stack();
            // s.Peek("Hola");


            ///////////////////////////////////////////
            //bool capicua;
            //String numero;
            //PilaLista pila = new PilaLista();
            //ColaCircular colaCirc = new ColaCircular();

            //try
            //{
            //    capicua = false;
            //    while (!capicua)
            //    {
            //        do
            //        {
            //            Console.WriteLine("\nTeclea un numero: ");
            //            numero = Console.ReadLine();
            //        } while (!validacion(numero));

            //        //PONE CADA DIGITO EN LA COLA Y EN LA PILA
            //        for (int i = 0; i < numero.Length; i++)
            //        {
            //            char c;
            //            c = numero[i];
            //            colaCirc.insertar(c);
            //            pila.insertar(c);
            //        }

            //        //SE RETIRA DE LA COLA Y PILA PARA COMPARAR
            //        do
            //        {
            //            Char d;
            //            d = (char)colaCirc.quitar();
            //            capicua = d.Equals(pila.quitar()); //COMPARA LA IGUALDAD


            //        } while (capicua && !colaCirc.colaVacia());

            //        if (capicua)
            //        {
            //            Console.WriteLine($"El numero {numero} es capicua");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"El numero {numero} no es capicua");
            //            Console.WriteLine("INTENTE CON OTRO!!");
            //        }

            //        //VACIAR ESTRUCTURAS
            //        colaCirc.borrarCola();
            //        pila.limpiarPila();
            //    }


            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error en {e.Message}");
            //}

            /////////////////////////////////////////////////////////

            //QUEUE
            //Queue qt = new Queue();
            //qt.Enqueue("Hola");
            //qt.Enqueue("esta");
            //qt.Enqueue("es");
            //qt.Enqueue("una");
            //qt.Enqueue("prueba");

            //Console.WriteLine($"La cola tiene {qt.Count} elementos");
            //Console.WriteLine($"Desencolando {qt.Dequeue()}");
            //Console.WriteLine($"Ahora la cola tiene {qt.Count} elementos");

            
            //Validar val = new Validar();
            //string n = Console.ReadLine();
            //Validar.esNUMERO(n);


            EjemploStackQueue ej = new EjemploStackQueue();
            ej.CapicuaStackQueue();


        }
    }
}
