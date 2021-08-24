using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader leer = new StreamReader(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\DatosExtracto.txt"))
            {

                var Clientes = new List<string>();

                for (int x = 0; x < 20; x++)
                {
                    Clientes.Add(leer.ReadLine());
                }
            };
        }
    }
}
