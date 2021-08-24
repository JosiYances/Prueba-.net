using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppControl
{
    class Imprimir
    {

        string[,] iImp = new string[20, 15];
        string[] ClienteImp = new string[15];

        public void Gestionar(string Use)
        {

            using (StreamReader leer = new StreamReader(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\DatosPagoExtracto.txt"))
            {
                string U;

                List<string> Reci = new List<string>();

                int z = 0;
                for (int x = 0; x < 20; x++)
                {
                    U = leer.ReadLine();
                    Reci = U.Split(';').ToList();

                    int y = 0;
                    foreach (var dato1 in Reci)
                    {
                        iImp[z, y] = dato1.ToString();
                        y++;
                    }
                    z++;
                }
            };

            for (int x = 0; x < 20; x++)
            {
                if (iImp[x, 0] == Use)
                {
                    for (int y = 0; y < 15; y++)
                    {
                        ClienteImp[y] = iImp[x, y];
                    }
                }
            }

            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc,
                       new FileStream(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\FACTURAS PDF\IMPRIMIR\" + Use + ".PDF", FileMode.Create));
            doc.Open();

            iTextSharp.text.Font _StandarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph("Factura cuenta " + ClienteImp[0]));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Subtotal $" + ClienteImp[1]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("IVA $" + ClienteImp[2]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Total: $" + ClienteImp[3]));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph(ClienteImp[4]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Facturas anteriores: " + ClienteImp[5]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Interes por mora: $" + ClienteImp[6]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Gastos de cobrabza: $" + ClienteImp[7]));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Total pago anterior: $" + ClienteImp[8]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Saldo anterior: $" + ClienteImp[9]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Interes por mora: $" + ClienteImp[10]));
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Gastos de cobrabza: $" + ClienteImp[11]));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("Factura del mes: $" + ClienteImp[12]));
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph("TOTAL A PAGAR: $" + ClienteImp[13]));

            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);
            doc.Add(Chunk.NEWLINE);

            doc.Add(new Paragraph(ClienteImp[14]));

            doc.Close();
            writer.Close();

            
            try
            {
                //Process.Start(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\FACTURAS PDF\IMPRIMIR\" + Use + ".PDF");
                MessageBox.Show("Cuenta " + Use + " impresa");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al imprimir");
            }

            return;
        }
    }
}
