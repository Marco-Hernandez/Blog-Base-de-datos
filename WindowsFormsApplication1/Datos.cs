using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public class Datos : MySql
    {
        public Datos()
        {
        }
        public void insertar(string autor, string titulo , string contenido, string fecha)
        {
           


            this.abrirConexion();
            string sql = "INSERT INTO `libro` (`autor`, `titulo`, `contenido`, `fecha`) VALUES ('" + autor + "', '" + titulo + "', '" + contenido + "', '" + fecha + "')";
            this.ejecutarComando(sql);
            this.cerrarConexion();
        }

        private int ejecutarComando(string sql)
        {
            MySqlCommand myCommand = new MySqlCommand(sql, this.myConnection);
            int afectadas = myCommand.ExecuteNonQuery();
            myCommand.Dispose();
            myCommand = null;
            return afectadas;
        }
    }
}