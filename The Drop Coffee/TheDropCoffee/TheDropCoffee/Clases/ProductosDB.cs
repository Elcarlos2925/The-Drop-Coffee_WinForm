using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheDropCoffee.Clases
{
    internal class ProductosDB
    {
        public void MostrarProductos (DataGridView TablaProductos) 
        {
            try
            {
                CConexiòn objConexión = new CConexiòn();
                String Query = "select * from productos";
                TablaProductos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, objConexión.establecerConexión());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                TablaProductos.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se muestran los datos" + e.ToString());
            }
        }
    }
}
