using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDropCoffee.Clases
{
    internal class CConexiòn
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "the_drop_coffee";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";


        string cadenaConexión = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexión()
        {
            try
            {
                conex.ConnectionString = cadenaConexión;
                conex.Open();
                //MessageBox.Show("Se logro la conexión de la base de datos");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se conecto la base de datos" + ex.ToString());
            }
            return conex;
        }
    }
}
