using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.ColaArreglo
{
    class ColaCircular
    {
        private static int fin;
        private static int MAXTAMQ = 99;
        protected int frente;

        protected Object[] listaCola;

        //Avanza posicion
        private int siguiente(int r)
        {
            return (r + 1) % MAXTAMQ;
        }

        //CONSTRUCTOR
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            listaCola = new object[MAXTAMQ];
        }

        //VALIDACIONES
        public bool colaVacia()
        {
            return frente == siguiente(fin);
        }

        public bool colaLlena()
        {
            return frente == siguiente(siguiente(fin));
        }

        //OPERACIONES DE MODIFICACION DE COLA
        public void insertar(Object elemento)
        {
            if (!colaLlena())
            {
                fin = siguiente(fin);
                listaCola[fin] = elemento;
            }
            else
            {
                throw new Exception("OverFlow de la cola");
            }
        }

        //QUITAR ELEMENTO
        public Object quitar()
        {
            if (!colaVacia())
            {
                Object tm = listaCola[frente];
                frente = siguiente(frente);
                return tm;
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        //LIMPIAR O BORRAR COLA
        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ -1;
        }

        //OBTENER EL VALOR DE FRENTE
        public Object frenteCola()
        {
            if (!colaVacia())
            {
                return listaCola[frente];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }
    }
}
