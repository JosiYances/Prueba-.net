using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AppControl
{
    public partial class Usarios : Form
    {
        string[,] Clientes = new string[20, 10];

        public Usarios()
        {
            InitializeComponent();

            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRUCTURA ARCHIVO EXTRACOS DATOS CLIENTE.xlsx";
            SLDocument sl = new SLDocument(path);

            string[] Titulos = new string[10];
            int iRow = 7;

            for (int p = 0; p < 10; p++)
            {
                Titulos[p] = sl.GetCellValueAsString(iRow, 2);
                iRow++;
            }


            TCuenta.Text = Titulos[0];
            TContrato.Text = Titulos[1];
            TFechaF.Text = Titulos[2];
            TFechaV.Text = Titulos[3];
            TValor.Text = Titulos[4];
            TRazon.Text = Titulos[5];
            TNombre.Text = Titulos[6];
            TID.Text = Titulos[7];
            TDireccion.Text = Titulos[8];
            TCiudad.Text = Titulos[9];





            using (StreamReader leer = new StreamReader(@"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\DatosExtracto.txt"))
            {
                string U;


                List<string> Prueba = new List<string>();

                int z = 0;
                for (int x = 0; x < 20; x++)
                {
                    U = leer.ReadLine();
                    Prueba = U.Split(';').ToList();

                    int y = 0;
                    foreach (var dato1 in Prueba)
                    {
                        Clientes[z, y] = dato1.ToString();
                        y++;
                    }
                    z++;

                }

                for (int w = 0; w < 20; w++)
                {
                    Cuenta.Items.Add(Clientes[w, 0]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Contrato.Items.Add(Clientes[w, 1]);
                }

                for (int w = 0; w < 20; w++)
                {
                    FechaF.Items.Add(Clientes[w, 2]);
                }

                for (int w = 0; w < 20; w++)
                {
                    FechaV.Items.Add(Clientes[w, 3]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Valor.Items.Add(Clientes[w, 4]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Razon.Items.Add(Clientes[w, 5]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Nombre.Items.Add(Clientes[w, 6]);
                }

                for (int w = 0; w < 20; w++)
                {
                    ID.Items.Add(Clientes[w, 7]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Direccion.Items.Add(Clientes[w, 8]);
                }

                for (int w = 0; w < 20; w++)
                {
                    Ciudad.Items.Add(Clientes[w, 9]);
                }
            };

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
       

        private void ENVIAR_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRACTOS DE ENVIO MAIL.xlsx";
            SLDocument sl = new SLDocument(path);

            string[] UseMail = new string[7];
            string[] Correo = new string[7];


            for (int x = 0; x < 7; x++)
            {
                UseMail[x] = sl.GetCellValueAsString(x + 2, 1);
                Correo[x] = sl.GetCellValueAsString(x + 2, 2);
            }

            //Verifica Cuentas a Enviar
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (Clientes[x, 0] == UseMail[y])
                    {
                        string[] DClientes = new string[10];

                        for (int z = 0; z < 10; z++) 
                        {
                            DClientes[z] = Clientes[x, z];
                        }

                        EnvioCorreo prueba1 = new EnvioCorreo();
                        prueba1.Gestionar(DClientes, Correo[y]);                    

                    }
                }

            }
            MessageBox.Show("Facturas enviadas correctamente");


            string pathI = @"C:\Users\JOSIMAR HERNANDEZ\Desktop\PRUEBA CARVAJAL\Prueba\DatosEntrada\EXTRACTOS A RETENER.xlsx";
            SLDocument slI = new SLDocument(pathI);

            string[] Retener = new string[6];



            for (int x = 0; x < 6; x++)
            {
                Retener[x] = slI.GetCellValueAsString(x + 2, 1);

            }

            //Verifica Cuentas  Imprimir
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    if (Clientes[x, 0] != Retener[y])
                    {
                        for (int z = 0; z < 7; z++)
                        {
                            if (Clientes[x, 0] == UseMail[z])
                            {
                                z = 7;
                                x++;
                                y = -1;
                            }
                            else if(z==6 & y==5)
                            {
                                string[] DClientes = new string[10];
                                for (int i = 0; i < 10; i++)
                                {
                                    DClientes[i] = Clientes[x, i];
                                    
                                }
                                Imprimir pruebaI = new Imprimir();
                                pruebaI.Gestionar(DClientes);

                            }
                        }

                    }
                    else 
                    {
                        MessageBox.Show("Cuenta " + Clientes[x, 0] + " Retenida");                       
                        y = 6;
                    }

                    

                }             
               


            }

        }        
         
    }

    
}