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
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
            this.ControlBox = false;
            Clases.CConexiòn obj = new Clases.CConexiòn();
            obj.establecerConexión();
            //btnIniciarseciònEmpleado.Enabled = false;
        }
        public void btnIniciarseciònEmpleado_Click(object sender, EventArgs e)
        {
            /*Clases.Personal obj = new Clases.Personal();
            if ( opc == 1)
            {
                obj.Administradores(txtUsuarioAdmin, txtPasswordAdmin);
            }
            if (opc ==2)
            {
                obj.AdminMenu(txtUsuarioAdmin, txtPasswordAdmin);
            }*/

            RegistroEmpleados obj= new RegistroEmpleados();
            obj.Show();

            Close();
        }
        private void txtPasswordAdmin_Leave(object sender, EventArgs e)
        {
            if (txtPasswordAdmin.Texts == "")
            {
                txtPasswordAdmin.PasswordChar = false; 
                txtPasswordAdmin.Texts = "Ingrese Contraseña"; 
            }
        }
        private void txtUsuarioAdmin_Leave(object sender, EventArgs e)
        {
            if (txtUsuarioAdmin.Texts == "")
            {
                txtUsuarioAdmin.Texts = "Ingrese Usuario";
            }
        }
        private void txtUsuarioAdmin_Enter(object sender, EventArgs e)
        {
            if (txtUsuarioAdmin.Texts == "Ingrese Usuario")
            {
                txtUsuarioAdmin.Texts = "";
                txtUsuarioAdmin.ForeColor = Color.Black;
            }
        }
        private void txtPasswordAdmin_Enter(object sender, EventArgs e)
        {
            if (txtPasswordAdmin.Texts == "Ingrese Contraseña")
            {
                txtPasswordAdmin.Texts = "";
                txtPasswordAdmin.PasswordChar = true;
            }
        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}