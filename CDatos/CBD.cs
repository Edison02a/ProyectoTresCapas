using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CDatos
{
    public class CBD
    {
        public string cadena = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=Proveedor;Integrated Security=True";
        //public string cadena = "Data Source=.;Initial Catalog=Proveedor;Persist Security Info=True;User ID=sa;Password=sqlserver";
        public SqlConnection conectar = new SqlConnection();
        public CBD()
        {
            conectar.ConnectionString = cadena;
        }

        public void Abrir()
        {
            try
            {
                conectar.Open(); Console.WriteLine("Conexión exitosa");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Cerrar()
        {
            conectar.Close();
        }
    }
}
