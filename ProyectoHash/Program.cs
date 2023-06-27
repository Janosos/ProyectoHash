﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo Nombre: numero
            // El nombre servira para hacer el hash

            Console.WriteLine("Ejemplo de hash: ");
            int n = 5;
            CHash cHash = new CHash(n);

            Elemento e1 = new Elemento("Juan", 1239430123);
            Elemento e2 = new Elemento("Mario", 1239011109);
            // Claves identicas no se agregan
            Elemento e3 = new Elemento("Mario", 230232389);
            // Mayusculas y minusculas se consideran como diferentes
            Elemento e4 = new Elemento("mario", 230232389);

            Elemento e5 = new Elemento("Jose", 230232389);
            Elemento e6 = new Elemento("Raul", 230232389);
            Elemento e7 = new Elemento("Max", 230232389);
            cHash.Agregar(e1);
            cHash.Agregar(e2);
            cHash.Agregar(e3);
            cHash.Agregar(e4);
            cHash.Agregar(e5);
            cHash.Agregar(e6);
            cHash.Agregar(e7);
            Console.WriteLine(cHash);

            Console.WriteLine("Ejemplo modificado: ");
            cHash.Eliminar(cHash.Buscar("Mario"));

            Console.WriteLine(cHash);

            Console.ReadKey();
        }
    }
}
