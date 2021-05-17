using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Pila_Lista
{
    class PilaLista
    {
        private static int INICIAL = 19;
        private int cima;
        private List<Object> listaPila;

        //CONSTRUCTOR
        public PilaLista()
        {
            cima = -1;
            listaPila = new List<object>();
        }

        //VALIDADORES
        public bool pilaVacia()
        {
            return cima == -1;
        }

        public Object cimaPila()
        {
            if (!pilaVacia())
            {
                throw new Exception("No es posible extraer el elemento");
            }
            return listaPila[cima];
        }

        //METODOS DE PILA CIRCULAR
        //INSERTAR
        public void insertar(Object elemento)
        {
            cima++;
            listaPila.Add(elemento);
        }

        //QUITAR
        public Object quitar()
        {
            Object aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no hay elementos para extraer");
            }

            aux = listaPila[cima];
            cima--;
            return aux;
        }

        //LIMPIAR PILA
        public void limpiarPila()
        {
            while (pilaVacia())
            {
                quitar();
            }
        }











    }//END CLASE
}
