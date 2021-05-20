using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Ejemplos
{
    class EjemploStackQueue
    {
        //EVALUAR SI ES CAPICUA UN NUMERO QUE SE INGRESE POR CONSOLA
        //CON ESTRUCTURA DE DATOS STACK Y QUEUE

        //DETERMINAR SI ES NUMERO EL DATO INGRESADO
        public bool validacion(String numero)
        {
            bool sw = true;
            int i = 0;
            while (sw && (i < numero.Length))
            {
                char digito;
                digito = numero[i++];
                sw = (digito >= '0' && digito <= '9');
            }
            return sw;
        }

        public void CapicuaStackQueue()
        {
            String entrada;
            bool capicua;
            //PARA EL EJEMPLO SE UTILIZA LA COLECCION GENERICA Stack<T>
            //CREAMOS LOS OBJETOS
            Stack<char> pila_Stack = new();
            Queue<char> cola_Queue = new();

            try
            {
                capicua = false;

                do
                {
                    Console.WriteLine("\nIngrese un numero, para determinar si es Capicua: ");
                    entrada = Console.ReadLine();
                } while (!validacion(entrada));

                //INSERTAR DATOS
                //EL DIGITO SE COLOCA EN LA COLA Y EN LA PILA 
                for (int i = 0; i < entrada.Length; i++)
                {
                    char digito;
                    digito = entrada[i];
                    pila_Stack.Push(digito);//PUSH: MÉTODO PARA AGREGAR UN ELEMENTO A LA PILA STACK
                    cola_Queue.Enqueue(digito);//ENQUEUE: MÉTODO PARA AGREGAR UN ELEMENTO AL INICIO EL LA FILA/COLA
                }

                //SACAR DATOS
                //EXTRAER EL DIGITO DE LA COLA Y DE LA PILA PARA EVALUAR
                do
                {
                    char digito;
                    digito = cola_Queue.Dequeue();//DEQUEUE: DEVUELVE UN ELEMENTO DEL PRINCIPIO DE LA COLA Y LO ELIMINA DE LA COLA
                    capicua = digito.Equals(pila_Stack.Pop()); //POP: ELIMINA Y DEVUELVE ELEMENTOS DE LA PARTE SUPERIOR DE LA PILA
                } while (capicua && cola_Queue.Count != 0);

                if (capicua)
                {
                    Console.WriteLine($"\nNumero {entrada} es capicua");
                }
                else
                {
                    Console.WriteLine($"\nNumero {entrada} no es capicua");
                    Console.WriteLine("\n*INTENTE DE NUEVO*");
                    new EjemploStackQueue().CapicuaStackQueue();
                }
                //LIMPIAR ESTRUCTURAS
                pila_Stack = new Stack<char>();
                cola_Queue = new Queue<char>();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
