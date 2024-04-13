using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_13_04.ClsConsola
{
    internal class ClsConsola
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Marca:{Marca}, AnioLanzamineto:{AnioLanzamiento}");
        }
    }
}
