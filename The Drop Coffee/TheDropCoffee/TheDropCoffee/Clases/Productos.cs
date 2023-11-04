using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.AxHost;


namespace TheDropCoffee.Clases
{
    internal class Productos
    {
        public double Total { get; set; }
        public string Descripción { get; set; }
        public int MenosCount(int Cantidad, Button bttnMenos)
        {
            /*Menos = */Cantidad = Cantidad- 1;
            if (Cantidad == 0) 
            {
                bttnMenos.Enabled = false; 
            }
            else 
            { 
                bttnMenos.Enabled = true; 
            }return Cantidad;
        }
        public int MasCount(int Cantidad, Button bttnMenos)
        {
            /*Mas*/  Cantidad = Cantidad+ 1;
            if (Cantidad == 0) 
            {
                bttnMenos.Enabled = false; 
            }
            else 
            { 
                bttnMenos.Enabled = true; 
            }return Cantidad;
        }
        public double TotalProducto(double Precio, int Cantidad)
        {
            Precio = Precio * Cantidad;
            Total = Precio;
            return Total;
        }
        public string ProductoDescripción(string Nombre,double Precio, int cantidad)
        {
            Precio = Precio * cantidad;
            Descripción = (cantidad+"\t " + Nombre +" \t$ "+Precio+"\n");
            return Descripción;
        }
        public void DesactivarBotones(Button bttnMenosAmericano, Button bttnMenosCappuccino, Button bttnMenosWhiteMocha, Button bttnMenosTeaMatcha,
            Button bttnMenosGalleta, Button bttnMenosPastel, Button bttnMenosLatte, Button bttnMenosChocolate,
            Button bttnMenosMocha, Button bttnMenosFrapuccino, Button bttnMenosBrownie, Button bttnMenosSandwich)
        {
            bttnMenosAmericano.Enabled = false;
            bttnMenosCappuccino.Enabled = false;
            bttnMenosWhiteMocha.Enabled = false;
            bttnMenosTeaMatcha.Enabled = false;
            bttnMenosGalleta.Enabled = false;
            bttnMenosPastel.Enabled = false;
            bttnMenosLatte.Enabled = false;
            bttnMenosChocolate.Enabled = false;
            bttnMenosMocha.Enabled = false;
            bttnMenosFrapuccino.Enabled = false;
            bttnMenosBrownie.Enabled = false;
            bttnMenosSandwich.Enabled = false;
        }

        public void ImprimirTicket (DateTimePicker Fecha, ComboBox PedidoPara,string productos, double Total,double Cambio,double Monto,double Subtotal,double IVA)
        {
            Monto = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese Efectivo: ", "CAMBIO"));
            Cambio = Monto - Total;
            IVA = Total * (0.08);
            Subtotal = Total - IVA;

            StreamWriter Venta = new StreamWriter(@"C:\Users\Telnor\Desktop\Programación II\Archivo.txt", true);
            //StreamWriter Venta = new StreamWriter(@"C:\Users\cl154\Downloads\Drop Coffee 0.1.4a\Archivo.txt", true);
            //StreamWriter Venta = new StreamWriter(@"I:\Programación II\Archivo.txt", true);
            try
            {
                Venta.WriteLine("===== \tTHE DROP COFFE S.A DE C.V\n=====");
                Venta.WriteLine("Av Castillo de Chapultepec, Tomas Aquino\n \tC.P. 22414 Tijuana, B.C.\n \t  RESTAURANTE 307 C\n\n");
                Venta.WriteLine(Fecha.Text+"\n");
                Venta.WriteLine(PedidoPara.Text + "\n\n");
                Venta.WriteLine("Productos\n\n" + productos);
                Venta.WriteLine("\tSubtotal            $\t" + Subtotal);
                Venta.WriteLine("\tIVA 8%              $\t" + IVA);
                Venta.WriteLine("\tTotal               $\t" + Total);
                Venta.WriteLine("\tEfectivo            $\t" + Monto);
                Venta.WriteLine("\tCambio              $\t" + Cambio);
            }
            catch
            {
                MessageBox.Show("Lo sentimos, su registro no logro ser guardado exitosamente.", "Error al guardar registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Venta.Close();
                                                                      
            MessageBox.Show("====THE DROP COFFE S.A DE C.V====\n"+
                "Av Castillo de Chapultepec, Tomas Aquino\n \tC.P. 22414 Tijuana, B.C.\n \t  RESTAURANTE 307 C\n\n" + 
                Fecha.Text + "\n\n" + 
                PedidoPara.Text + "\n" + 
                "PRODUCTOS\n" +productos+
                "\nSubTotal     $" +Subtotal+
                "\nIVA 8%         $" +IVA+
                "\nTOTAL          $" +Total+
                "\nEFECTIVO    $" +Monto+
                "\nCAMBIO       $" +Cambio+
                "\n\n\t¡Gracias por su Compra!", "Ticket") ;
        }
        public void Info(int opc)
        {
            //========================Botones Información=========================
            if(opc==0)
            {
                //Botón Información Cafe Americnao 
                MessageBox.Show("Bedida caliente de 8oz\n\nEs un café que consiste en partes exactamente iguales de espresso y agua.", "Información Cafe Americano", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(opc==1)
            {
                //Botón Información Cappucciono
                MessageBox.Show("Bebida caliente de 16oz\n\nContiene un shot de espresso con leche y mucha espuma", "Información Cappuccino", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==2)
            {
                //Botón Información White Mocha
                MessageBox.Show("Bebida caliente de 16oz\n\nCafé Espresso con capas de mocha y mocha blanco combinadas en leche vaporizaday chispas sabor chocolate. No lleva crema batida. Sin endulzantes.", "Información White Mocha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==3)
            {
                //Botón Información Tea Matcha
                MessageBox.Show("Bebida fria de 16oz\n\n Contiene crema batida a base de leche entera", "Información Tea Matcha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==4)
            {
                //Botón Información Galleta
                MessageBox.Show("Porción individual de 45 gr\n\nClasica galleta con chispas de chocolate", "Información Galleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(opc==5)
            {
                //Botón Información Pastel
                MessageBox.Show("Rebanada de pastel del día de 120g", "Información Pastel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==6) 
            {
                //Botón Información Latte
                MessageBox.Show("Bebida caliente de 16oz\n\nContiene un shot de espresso con mucha leche y espuma ", "Información Latte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==7)
            {
                //Botón Información Chocolate
                MessageBox.Show("Bedida caliente de 16oz\n\nContiene leche vaporizada combinada con salsa de chocolate y vainilla, cubierto con crema batida y espiral de salsa de chocolate", "Información Chocolate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==8)
            {
                //Botón Información Mocha
                MessageBox.Show("Bebida caliente de 16oz\n\nContiene un espresso con leche y salsa de chocolate", "Información Mocha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==9)
            {
                //Botón información Frappucciono
                MessageBox.Show("Bebida fria de 16 oz\n\nContiene café con leche y hielo", "Información Frappucciono", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==10)
            {
                //Botón Información Brownie
                MessageBox.Show("Porción individual de 105gr\n\nClásico brownie sabor chocolate", "Información Brownie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (opc==11)
            {
                //Botón Información Sandwich
                MessageBox.Show("Sandwich de pierna\n\nContiene pan de 12 granos con queso crema, jamón de pierna, queso manchego, lechuga, tomate y alfalfa", "Información Sandwich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //========================Botones Información========================
        }
    }
}