using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class CHash
    {
        public List<Elemento>[] Contenido;
        public int Longitud;

        public CHash(int n)
        {
            Contenido = new List<Elemento>[n];
            for (int i = 0; i < n; i++)
            {
                Contenido[i] = new List<Elemento>();
            }
            Longitud = n;
        }

        public int Hash(string clave)
        {
            // operamos con la clave
            char[] chars = clave.ToCharArray();
            int sumador = 0;
            for (int i = 0; i < chars.Length; i++)
                sumador += Convert.ToInt32(chars[i]) * (i + 1);
            return sumador % Longitud;
        }

        public void Agregar(Elemento elemento)
        {
            int index = Hash(elemento.Clave);
            if (Buscar(elemento.Clave) == null)
                Contenido[index].Add(elemento);
        }
         
        public Elemento Buscar(string clave)
        {
            int index = Hash(clave);
            for (int i = 0; i < Contenido[index].Count; i++)
            {
                if (Contenido[index][i].Clave == clave)
                    return Contenido[index][i];
            }
            return null;
        }

        public void Eliminar(Elemento elemento)
        {
            int index = Hash(elemento.Clave);
            for (int i = 0;i < Contenido[index].Count;i++)
                if (Contenido[index][i].Clave == elemento.Clave)
                    Contenido[index].RemoveAt(i);
        }

        public override string ToString()
        {
            string str = "";
            int n = 0;
            foreach (List<Elemento> elemento in Contenido)
            {
                str += n + ": ";
                foreach (Elemento elemento2 in elemento)
                    str += elemento2.ToString() + " ";
                str += "\n";
                n++;

            }
            return str;
        }
    }
}
