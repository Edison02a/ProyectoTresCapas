using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
            cBD.Cerrar();
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
                        CedulaProv = Convert.ToInt32(sqlreader["ci"]),
                        NombreProv = Convert.ToString(sqlreader["nombreP"]),
                        ApellidoProv = Convert.ToString(sqlreader["apellido"]),
                        DireccionProv = Convert.ToString(sqlreader["direccion"]),
                        CiudadProv = Convert.ToString(sqlreader["ciudad"]),
                        ProviciaProv = Convert.ToString(sqlreader["provincia"]),

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
            cBD.Cerrar();
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
                        IdPieza = Convert.ToInt16(sqlreader["id"]),
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

        public List<EntidadesSuministra> Obtener3()
        {
            cBD.Cerrar();
            List<EntidadesSuministra> DatosSuministra = new List<EntidadesSuministra>();
            try
            {
                cBD.Abrir();
                SqlCommand sql = new SqlCommand("Select * from suministra", cBD.conectar);
                SqlDataReader sqlreader = sql.ExecuteReader();
                while (sqlreader.Read())
                {
                    EntidadesSuministra objEnt3 = new EntidadesSuministra()
                    {
                        CantidadSuministra = Convert.ToInt32(sqlreader["cantidad"]),
                        IdPieza = Convert.ToInt32(sqlreader["id_pieza"]),
                        IdProveedor = Convert.ToInt32(sqlreader["id_proveedor"]),
                    };
                    DatosSuministra.Add(objEnt3);


                }
                return DatosSuministra;
            }
            catch
            {

                DatosSuministra = null;
                cBD.Cerrar();
                return DatosSuministra;
            }
        }


        public List<EntidadesCategoria> Obtener4()
        {
            cBD.Cerrar();
            List<EntidadesCategoria> datosCategorias = new List<EntidadesCategoria>();
            try
            {
                cBD.Abrir();
                SqlCommand sql = new SqlCommand("Select * from categoria ", cBD.conectar);
                SqlDataReader sqlreader = sql.ExecuteReader();
                while (sqlreader.Read())
                {
                    EntidadesCategoria objEnt4 = new EntidadesCategoria()
                    {
                        IdCateogoria = Convert.ToInt32(sqlreader["id"]),
                        CategCategoria = Convert.ToString(sqlreader["categ"]),
                        PrecioCategoria = Convert.ToString(sqlreader["precio"]),
                    };
                    datosCategorias.Add(objEnt4);
                    

                }
                return datosCategorias;
                
            }
            catch
            {

                datosCategorias = null;
                cBD.Cerrar();
                return datosCategorias;
            }
        }

        //INSERTAR DATOS
        
        public void registrarProveedor(Entidades datos)
        {
            cBD.Abrir();
            string sql = "insert into prov(nombreP,ci,apellido,direccion,ciudad,provincia) VALUES('" + datos.NombreProv + "','" + datos.CedulaProv + "','" + datos.ApellidoProv + "' ,'" + datos.DireccionProv+ "', '" + datos.CiudadProv + "', '" + datos.ProviciaProv + "')";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        public void registrarCategoria(EntidadesCategoria datosCateg)
        {
            cBD.Abrir();
            string sql = "insert into categoria(categ,precio) VALUES('" + datosCateg.CategCategoria + "', '" + datosCateg.PrecioCategoria + "')";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }
        public void registrarPieza(EntidadesPieza datosPieza)
        {
            cBD.Abrir();
            string sql = "insert into pieza(nombre,color,centro,categ) VALUES('" + datosPieza.NombrePieza + "', '" + datosPieza.ColorPieza + "', '" + datosPieza.CentroPieza + "', '" + datosPieza.CategoriaPieza + "')";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }
        public void registrarSuministrar(EntidadesSuministra datosSuministra)
        {
            cBD.Abrir();
            string sql = "insert into suministra(cantidad,id_pieza,id_proveedor) VALUES('" + datosSuministra.CantidadSuministra + "', '" + datosSuministra.IdPieza + "', '" + datosSuministra.IdProveedor + "')";
            SqlCommand comando = new SqlCommand(sql, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        public Entidades BuscarId(int ciPr)
        {
            cBD.Abrir();
            string consulta = "SELECT Pr.nombreP, Pr.apellido FROM prov Pr WHERE Pr.ci = @ciProv";

            SqlCommand cmd = new SqlCommand(consulta, cBD.conectar);
            cmd.Parameters.AddWithValue("@ciProv", ciPr);

            SqlDataReader dr = cmd.ExecuteReader();
            Entidades proveedor = null;

            if (dr.Read())
            {
                proveedor = new Entidades();
                proveedor.NombreProv = dr["nombreP"].ToString();
                proveedor.ApellidoProv = dr["apellido"].ToString();
                dr.Close();
            }
            
            cBD.Cerrar();
            return proveedor;
        }

        public List<EntidadesPieza> ObtenerPiezasProveedor(int ciProveedor)
        {

            cBD.Abrir();
            string consulta = "SELECT P.id, P.nombre, P.color, P.centro, P.categ, S.cantidad FROM pieza P INNER JOIN suministra S ON P.id=S.id_pieza WHERE S.id_proveedor = @ciProv";

            SqlCommand cmd = new SqlCommand(consulta, cBD.conectar);
            cmd.Parameters.AddWithValue("@ciProv", ciProveedor);

            SqlDataReader dr = cmd.ExecuteReader();
            List<EntidadesPieza> listaPiezas = new List<EntidadesPieza>();
            if (dr.Read())
            {
                while (dr.Read())
                {
                    EntidadesPieza pieza = new EntidadesPieza();
                    pieza.IdPieza = Convert.ToInt32(dr["id"]);
                    pieza.NombrePieza = dr["nombre"].ToString();
                    pieza.ColorPieza = dr["color"].ToString();
                    pieza.CentroPieza = dr["centro"].ToString();
                    pieza.CategoriaPieza = dr["categ"].ToString();
                    pieza.CantidadSuministrada = Convert.ToInt32(dr["cantidad"]);

                    listaPiezas.Add(pieza);
                }
                dr.Close();
            }
            cBD.Cerrar();
            return listaPiezas;
        }

        public EntidadesSuministra BuscarIdS(int ciPr)
        {
            cBD.Abrir();
            string consulta = "SELECT cantidad " +
                              "FROM suministra " +
                              "WHERE id_proveedor = @ciProv";

            SqlCommand cmd = new SqlCommand(consulta, cBD.conectar);
            cmd.Parameters.AddWithValue("@ciProv", ciPr);

            SqlDataReader dr = cmd.ExecuteReader();
            EntidadesSuministra suministro = null;

            if (dr.Read())
            {
                suministro = new EntidadesSuministra();
                suministro.CantidadSuministra = Convert.ToInt32(dr["cantidad"]);
                dr.Close();
            }
            
            cBD.Cerrar();
            return suministro;
        }


        public void ActualizarPieza(string nombrePieza, string colorPieza, string centroPieza, string categoriaPieza, int IdPieza, int ciProveedor, int cantidadSuministra)
        {
            cBD.Abrir();
            string consulta = "UPDATE pieza SET color = @color, centro = @centro, categ = @categoria WHERE nombre = @nombreP";
            SqlCommand cmd = new SqlCommand(consulta, cBD.conectar);
            cmd.Parameters.AddWithValue("@color", colorPieza);
            cmd.Parameters.AddWithValue("@centro", centroPieza);
            cmd.Parameters.AddWithValue("@categoria", categoriaPieza);
            cmd.Parameters.AddWithValue("@nombreP", nombrePieza);

            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                // Actualizar la tabla suministra

                consulta = "UPDATE suministra SET cantidad = @cantidad WHERE id_pieza = @idPieza";
                cmd = new SqlCommand(consulta, cBD.conectar);
                cmd.Parameters.AddWithValue("@cantidad", cantidadSuministra);
                cmd.Parameters.AddWithValue("@idPieza", IdPieza);
                cmd.ExecuteNonQuery();

                //MessageBox.Show("Los datos se actualizaron correctamente.");
            }
            else
            {
                //MessageBox.Show("No se pudo actualizar la pieza.");
            }

            cBD.Cerrar();
        }

        /*
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
