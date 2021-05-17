using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Cola_Lista
{
    class ColaLista
    {
        protected Nodo frente;
        protected Nodo fin;

        //CONSTRUCTOR
        public ColaLista()
        {
            frente = fin = null;
        }

        //VALIDADOR
        public bool colaVacia() => frente == null;

        //METODOS COLA
        //INSERTAR
        public void insertar(Object elemento)
        {
            Nodo x;
            x = new Nodo(elemento);

            if (colaVacia())
            {
                frente = x;
            }
            else
            {
                fin.siguiente = x;
            }
            fin = x;
        }

        //QUITAR
        public Object quitar()
        {
            Object aux;
            if (!colaVacia())
            {
                aux = frente.elemento;
                frente = frente.siguiente;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
            return aux;
        }

        //VACIAR COLA
        public void borrarCola()
        {
            for (; frente !=null;)
            {
                frente = frente.siguiente;
            }
        }

        //MOSTRAR VALOR FRENTE DE COLA
        public Object freteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Cola Vacia");
            }
            return (frente.elemento);
        }
    }
}
