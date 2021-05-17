using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaLineal
    {
        protected int fin;
        private static int MAXTAMQ = 39;
        protected int frente;

        protected Object[] listaCola;

        //constructor
        public ColaLineal()
        {
            frente = 0;
            fin = -1;
            listaCola = new object[MAXTAMQ];
        }

        //operaciones para trabajar condatos en la cola

        //cola vacia
        public bool colaVacia()
        {
            return frente > fin;
        }

        //cola llena
        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }

        //insertar
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                listaCola[++fin] = elemento;
            }
            else
            {
                throw new Exception("OverFlow de la Cola");
            }

        }

        //quitar elemento
        public Object quitar()
        {
            if (!colaVacia())
            {
                return listaCola[frente++];
            }
            else
            {
                throw new Exception("Cola vacia");
                ;
            }
        }

        //limpiar contenido de la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //acceso a la cola
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }
        }
    }//end clase
}
