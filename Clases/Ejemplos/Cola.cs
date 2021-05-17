using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas.Clases.Ejemplos
{
    class Cola
    {
        public void ejemploQUEUE()
        {
            Queue qt = new Queue();

            qt.Enqueue("Hola");
            qt.Enqueue("esta");
            qt.Enqueue("es");
            qt.Enqueue("una");
            qt.Enqueue("prueba");

            Console.WriteLine($"La cola tiene {qt.Count}");
        }

    }
}
