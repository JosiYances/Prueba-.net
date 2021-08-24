using SpreadsheetLight;
using System;
using System.Collections.Generic;

namespace Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRACTOS DE ENVIO MAIL.xlsx";
            SLDocument sl = new SLDocument(path);

            var UseMail = new List<string>();
            var Correo = new List<string>();

            for (int x = 2; x < 9; x++)
            {
                UseMail.Add(sl.GetCellValueAsString(x, 1));
                Correo.Add(sl.GetCellValueAsString(x, 2));
            }

            return;
        }

    }
    
}
