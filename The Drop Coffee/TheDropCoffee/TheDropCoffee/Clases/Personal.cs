using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using RJCodeAdvance.RJControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheDropCoffee.Formas;

namespace TheDropCoffee.Clases
{
    internal class Personal
    {

        //login administradores
        public void Administradores(RJTextBox Usuario, RJTextBox Password,Form forma) 
        {
            try
            {
                CConexiòn objConexiòn = new CConexiòn();
                String Query = "select Usuario,Admin_Password from Administradores where  Usuario = '"+Usuario.Texts+ "' and Admin_Password = '"+Password.Texts+"';";
                MySqlCommand MCommand = new MySqlCommand(Query, objConexiòn.establecerConexión());
                MySqlDataReader MyReader = MCommand.ExecuteReader();


                if (MyReader.Read())
                {
                    Menú x = new Menú(); 
                    x.Show();
                    /*forma y = new forma();
                    y.Show();*/
                }
                else { MessageBox.Show("Usuario o Contraseña Incorrectos"); }
            }
            catch(MySqlException e)
            {
                MessageBox.Show("Error al ingresar," + e.ToString());
            }
        }
        public void AdminMenu(RJTextBox Usuario, RJTextBox Password)
        {
            try
            {
                CConexiòn objConexiòn = new CConexiòn();
                String Query = "select Usuario,Admin_Password from Administradores where  Usuario = '" + Usuario.Texts + "' and Admin_Password = '" + Password.Texts + "';";
                MySqlCommand MCommand = new MySqlCommand(Query, objConexiòn.establecerConexión());
                MySqlDataReader MyReader = MCommand.ExecuteReader();


                if (MyReader.Read())
                {
                    Menú x = new Menú(); 
                    x.Show();
                   
                }
                else { MessageBox.Show("Usuario o Contraseña Incorrectos"); }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error al ingresar," + e.ToString());
            }
        }

        public void Empleados(RJTextBox ID, RJTextBox Nom, RJTextBox ApeP, RJTextBox ApeM, RJTextBox Telefono, RJTextBox RFC, RJTextBox Password)
        {
            try
            {
                CConexiòn objConex = new CConexiòn();
                string query = "insert into EMPLEADOS (id_Empleados,Nombres, Apellido_Materno, Apellido_Paterno, Telefono, RFC, UserPassword)" +
                "values(" + ID.Texts + ",'" + Nom.Texts + "','" + ApeM.Texts + "','" + ApeP.Texts + "','"+ Telefono.Texts+"','" + RFC.Texts +"',"+Password.Texts+");";
                MySqlCommand MCommand = new MySqlCommand(query, objConex.establecerConexión());
                MySqlDataReader MyReader = MCommand.ExecuteReader();
                MessageBox.Show("Se guardo exitosamente el registro en la base de datos", "Guardado exisosamente");
                while (MyReader.Read()) { }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Ocurrio un error " + e.ToString());
            }
        }

    }
}
