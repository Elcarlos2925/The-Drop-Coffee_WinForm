using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDropCoffee.Formas
{
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        private void lblRegistrar_Click(object sender, EventArgs e)
        {
            Login_Admin obj = new Login_Admin();
            obj.Show();

        }

        private void lblSistema_Click(object sender, EventArgs e)
        {
            Menú Obj = new Menú();
            Obj.Show();
            /*int x= 2;
            Formas.Login_Admin obj = new Formas.Login_Admin();
            obj.btnIniciarseciònEmpleado_Click(sender, e, x);*/
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            DialogResult OPC;
            OPC = MessageBox.Show("¿Seguro que desea salir y cerrar el sistema?", "Cerrar programa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (OPC == DialogResult.OK)
            {
                Application.Exit();

            }

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Drop Coffee® Versión 0.1.7\nCreado por:\n◾Lozoya Avalos Carlos Abraham\n◾Mendez Neri Omar Alexander\n\nUltima actualización: 07 de Mayo de 2023", "The Drop Coffee®");
        }
    }
    }
