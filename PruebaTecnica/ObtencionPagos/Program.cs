using System;
using System.Collections.Generic;
using System.IO;

namespace ObtencionPagos
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader leer = new StreamReader(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\DatosPagoExtracto.txt"))
            {

                var Pagos = new List<string>();

                for (int x = 0; x < 20; x++)
                {
                    Pagos.Add(leer.ReadLine());
                }
            };

        }
    }
}
