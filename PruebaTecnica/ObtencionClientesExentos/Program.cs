using SpreadsheetLight;
using System;
using System.Collections.Generic;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRACTOS A RETENER.xlsx";
            SLDocument sl = new SLDocument(path);

            var Exentos = new List<string>();

            for (int x = 2; x < 8; x++)
            {
                Exentos.Add(sl.GetCellValueAsString(x, 1));
            }

            return;
        }
    }
}
