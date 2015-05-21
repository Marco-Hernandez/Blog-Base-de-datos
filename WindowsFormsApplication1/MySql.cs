using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public class MySql
    {
        protected MySqlConnection myConnection;

        public MySql()
        {
        }

        protected void abrirConexion()
        {
            string connectionString =
            "Server=localhost;" +
            "Database=libros;" +
            "User ID=root;" +
            "Password=caselogic;" +
            "Pooling=false;";
            this.myConnection = new MySqlConnection(connectionString);
            this.myConnection.Open();
        }
        public void cerrarConexion()
        {
            this.myConnection.Close();
            this.myConnection = null;
        }

       

    }
}
