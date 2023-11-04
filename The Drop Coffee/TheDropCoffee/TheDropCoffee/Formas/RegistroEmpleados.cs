using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDropCoffee.Clases;

namespace TheDropCoffee.Formas
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnGuardarRegEmp_Click(object sender, EventArgs e)
        {
            Clases.Personal obj = new Clases.Personal();
            obj.Empleados(txtIdEmp, txtNomEmp, txtApeMatEmp, txtApePatEmp, txtTelEmp, txtRFCEmp, txtContraEmp);

            txtIdEmp.Texts = "";
            txtNomEmp.Texts = "";
            txtApePatEmp.Texts = "";
            txtApeMatEmp.Texts = "";
            txtTelEmp.Texts = "";
            txtRFCEmp.Texts = "";
            txtContraEmp.Texts = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtIdEmp.Texts = "";
            txtNomEmp.Texts = "";
            txtApePatEmp.Texts = "";
            txtApeMatEmp.Texts = "";
            txtTelEmp.Texts = "";
            txtRFCEmp.Texts = "";
            txtContraEmp.Texts = "";

        }
    }
}
