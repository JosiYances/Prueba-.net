using SpreadsheetLight;
using System;
using System.Collections.Generic;

namespace Clientes
{
    class Program
    {
        public static void Main()
        {
            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRUCTURA ARCHIVO EXTRACOS DATOS DE PAGO.xlsx";
            SLDocument sl = new SLDocument(path);

            var TitulosPagos = new List<string>();

            for (int x = 7; x < 22; x++)
            {
                TitulosPagos.Add(sl.GetCellValueAsString(x, 2));
            }

            return;
        }
    }
}
