using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;

namespace CDatos
{
    public class CDatos2
    {
        CBD cBD = new CBD();

        //recuperar datos del proveedor
        public List<Entidades> Obtener()
        {
            List<Entidades> DatosProveedor = new List<Entidades>();
            try
            {
                cBD.Abrir();
                SqlCommand sql = new SqlCommand("Select * from prov", cBD.conectar);
                SqlDataReader sqlreader = sql.ExecuteReader();
                while (sqlreader.Read())
                {
                    Entidades objEnt = new Entidades()
                    {
                        NombreProv = Convert.ToString(sqlreader["Nombre"]),
                        DireccionProv = Convert.ToString(sqlreader["Direccion"]),
                        CiudadProv = Convert.ToString(sqlreader["Ciudad"]),
                        ProviciaProv = Convert.ToString(sqlreader["Provincia"]),

                    };
                    DatosProveedor.Add(objEnt);


                }
                return DatosProveedor;
            }
            catch
            {

                DatosProveedor = null;
                cBD.Cerrar();
                return DatosProveedor;
            }
        }

        //recuperar datos de la pieza

        public List<EntidadesPieza> Obtener2()
        {
            List<EntidadesPieza> DatosPieza = new List<EntidadesPieza>();
            try
            {
                cBD.Abrir();
                SqlCommand sql = new SqlCommand("Select * from pieza", cBD.conectar);
                SqlDataReader sqlreader = sql.ExecuteReader();
                while (sqlreader.Read())
                {
                    EntidadesPieza objEnt2 = new EntidadesPieza()
                    {
                        NombrePieza = Convert.ToString(sqlreader["nombre"]),
                        ColorPieza = Convert.ToString(sqlreader["color"]),
                        CentroPieza = Convert.ToString(sqlreader["centro"]),
                        CategoriaPieza = Convert.ToString(sqlreader["categ"]),

                    };
                    DatosPieza.Add(objEnt2);


                }
                return DatosPieza;
            }
            catch
            {

                DatosPieza = null;
                cBD.Cerrar();
                return DatosPieza;
            }
        }



        //INSERTAR DATOS
        /*
        public void registrar(Entidades datos)
        {
            cBD.Abrir();
            string sql = "insert into Tabla_datos(Nombre,Apellido) VALUES('" + datos.NombreEst + "', '" + datos.ApellidoEst + "')";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        //eliminar
        public void EliminarV(int ide)
        {
            cBD.Abrir();
            string sql = "delete from Tabla_datos where IdEstu='" + ide + "'";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        public Entidades buscarPorID(int ides)
        {
            cBD.Abrir();
            string sql = "SELECT FROM Tabla_datos where IdEstu='" + ides + "'";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            //comando.ExecuteNonQuery();

            SqlDataReader dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {
                Entidades obje = new Entidades
                {
                    idEst = Convert.ToInt32(dataReader["IdEstu"]),
                    NombreEst = Convert.ToString(dataReader["Nombre"]),
                    ApellidoEst = Convert.ToString(dataReader["Apellido"])
                };
                dataReader.Close();
                return obje;
            }
            else
            {
                return null;
            }

        }
        */
    }
}
