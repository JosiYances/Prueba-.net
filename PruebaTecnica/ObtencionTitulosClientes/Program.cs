using SpreadsheetLight;
using System;
using System.Collections.Generic;

namespace Clientes
{
    public class Program
    {
        public static void Main()
        {
            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRUCTURA ARCHIVO EXTRACOS DATOS CLIENTE.xlsx";
            SLDocument sl = new SLDocument(path);

            var Titulos = new List<string>();            

                for (int x=7; x<17; x++)
            {
                Titulos.Add(sl.GetCellValueAsString(x, 2));
            }
              
            return;
        }
    }
}
