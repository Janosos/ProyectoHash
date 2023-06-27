using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class Elemento
    {
        public string Clave { get; set; }
        public int Valor { get; set; }

        public Elemento(string clave, int valor)
        {
            Clave = clave;
            Valor = valor;
        }

        public override string ToString()
        {
            return "[" + Clave + ":" + Valor + "]";
        }
    }
}
