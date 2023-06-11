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
                sqlreader.Close();
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
                sqlreader.Close();
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
                sqlreader.Close();
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
                sqlreader.Close();
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
            string cadena = "SELECT Pr.ci, Pr.nombreP, Pr.apellido, Pr.direccion, Pr.provincia, Pr.ciudad FROM prov Pr WHERE Pr.ci =" + ciPr + "";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();
            if (dataReader.Read())
            {

                Entidades objEnt = new Entidades()
                {
                    CedulaProv = Convert.ToInt32(dataReader["ci"]),
                    NombreProv = Convert.ToString(dataReader["nombreP"]),
                    ApellidoProv = Convert.ToString(dataReader["apellido"]),
                    DireccionProv = Convert.ToString(dataReader["direccion"]),
                    ProviciaProv = Convert.ToString(dataReader["provincia"]),
                    CiudadProv = Convert.ToString(dataReader["ciudad"])
                };
                dataReader.Close();
                cBD.Cerrar();
                return objEnt;

            }
            else
            {
                if (dataReader.Read())
                {
                    dataReader.Close();
                }
                dataReader.Close();
                return null;

            }


        }

        public EntidadesCategoria BuscarCat(string cat)
        {
            cBD.Abrir();
            string consulta = "SELECT * FROM categoria WHERE categ= @nombreCategoria";
            SqlCommand comando = new SqlCommand(consulta, cBD.conectar);
            comando.Parameters.AddWithValue("@nombreCategoria", cat);
            SqlDataReader dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {
                EntidadesCategoria categoria = new EntidadesCategoria()
                {
                    IdCateogoria = Convert.ToInt32(dataReader["id"]),
                    PrecioCategoria = Convert.ToString(dataReader["precio"]),
                    CategCategoria = Convert.ToString(dataReader["categ"])
                };

                dataReader.Close();
                cBD.Cerrar();
                return categoria;
            }
            else
            {
                dataReader.Close();
                cBD.Cerrar();
                return null;
            }
        }
        public void ActualizarCategoria(int idCategoria, string categoria, float precio)
        {
            cBD.Abrir();
            string consulta = "UPDATE categoria SET categ = @categoria,precio=@precio WHERE id = @idCategoria";

            SqlCommand comando = new SqlCommand(consulta, cBD.conectar);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }
        public List<EntidadesPieza> ObtenerPiezasProveedor(int ciProveedor)
        {
            List<EntidadesPieza> listaPiezas = new List<EntidadesPieza>();

            try
            {
                cBD.Abrir();
                string cadena = "SELECT P.id, P.nombre, P.color, P.centro, P.categ, S.cantidad FROM pieza P INNER JOIN suministra S ON P.id=S.id_pieza WHERE S.id_proveedor =" + ciProveedor + "";
                SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    EntidadesPieza pieza = new EntidadesPieza()
                    {
                        IdPieza = Convert.ToInt32(dataReader["id"]),
                        NombrePieza = Convert.ToString(dataReader["nombre"]),
                        ColorPieza = Convert.ToString(dataReader["color"]),
                        CentroPieza = Convert.ToString(dataReader["centro"]),
                        CategoriaPieza = Convert.ToString(dataReader["categ"]),
                        CantidadSuministrada = Convert.ToInt32(dataReader["cantidad"])
                    };

                    listaPiezas.Add(pieza);
                }
                if(dataReader.Read())
                {
                    dataReader.Close();
                }
                dataReader.Close();
                // Cerrar el SqlDataReader después de recorrer los datos
            }
            catch (Exception ex)
            {
                // Manejar la excepción apropiadamente
                Console.WriteLine("Error al obtener las piezas del proveedor: " + ex.Message);
            }
            finally
            {
                cBD.Cerrar();
            }

            return listaPiezas;
        }

        /*public EntidadesSuministra BuscarIdS(int ciPr)
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
        }*/


        public void ActualizarPieza(string nombrePieza, string colorPieza, string centroPieza, string categoriaPieza, int idPieza)
        {
            cBD.Abrir();
            string consulta = "UPDATE pieza SET nombre = @nombrePieza, color = @colorPieza, centro = @centroPieza, categ = @categoriaPieza WHERE id = @idPieza";

            SqlCommand comando = new SqlCommand(consulta, cBD.conectar);
            comando.Parameters.AddWithValue("@nombrePieza", nombrePieza);
            comando.Parameters.AddWithValue("@colorPieza", colorPieza);
            comando.Parameters.AddWithValue("@centroPieza", centroPieza);
            comando.Parameters.AddWithValue("@categoriaPieza", categoriaPieza);
            comando.Parameters.AddWithValue("@idPieza", idPieza);

            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        public void ActualizarProveedor(int ciProveedor, string nombreP, string apellido, string direccion, string provincia, string ciudad)
        {
            cBD.Abrir();
            string consulta = "UPDATE prov SET nombreP = @nombreP, apellido = @apellido, direccion =@direccion, provincia=@provincia, ciudad= @ciudad WHERE ci = @ciProveedor";

            SqlCommand comando = new SqlCommand(consulta, cBD.conectar);
            comando.Parameters.AddWithValue("@nombreP", nombreP);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@ciProveedor", ciProveedor);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@provincia", provincia);
            comando.Parameters.AddWithValue("@ciudad", ciudad);

            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }
        public void ActualizarSuministra(int idPieza, int ciProveedor, int cantidadSuministra)
        {
            cBD.Abrir();
            string consulta = "UPDATE suministra SET cantidad = @cantidadSuministra,id_proveedor=@ciProveedor WHERE id_pieza = @idPieza";

            SqlCommand comando = new SqlCommand(consulta, cBD.conectar);
            comando.Parameters.AddWithValue("@cantidadSuministra", cantidadSuministra);
            comando.Parameters.AddWithValue("@idPieza", idPieza);
            comando.Parameters.AddWithValue("@ciProveedor", ciProveedor);

            comando.ExecuteNonQuery();
            cBD.Cerrar();
        }

        //eliminar 

        public Entidades BuscaCedula(int ciPr)
        {
            cBD.Abrir();
            string cadena = "SELECT * FROM prov Pr WHERE Pr.ci =" + ciPr + "";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();
            if (dataReader.Read())
            {

                Entidades objEnt = new Entidades()
                {
                    CedulaProv = Convert.ToInt32(dataReader["ci"]),
                    NombreProv = Convert.ToString(dataReader["nombreP"]),
                    ApellidoProv = Convert.ToString(dataReader["apellido"]),
                    DireccionProv = Convert.ToString(dataReader["direccion"]),
                    ProviciaProv = Convert.ToString(dataReader["provincia"]),
                    CiudadProv = Convert.ToString(dataReader["ciudad"])

                };
                dataReader.Close();
                cBD.Cerrar();
                return objEnt;
            }
            else
            {
                return null;
            }


        }

        public void EliminarProvedeor(int ci2)
        {
            cBD.Abrir();
            string cadena = "Delete FROM pieza WHERE id IN(SELECT id_pieza FROM suministra WHERE id_proveedor ="+ ci2+");" + "delete from prov where ci=" + ci2 + ";";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();

        }

        //eliminar categoria

        public EntidadesCategoria BuscarCategorias(string categoria)
        {
            cBD.Abrir();
            string cadena = "SELECT * FROM categoria  WHERE categ = @categoria" ;
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            comando.Parameters.AddWithValue("@categoria", categoria);
            SqlDataReader dataReader = comando.ExecuteReader();
            if (dataReader.Read())
            {

                EntidadesCategoria objEnt = new EntidadesCategoria()
                {
                    CategCategoria = Convert.ToString(dataReader["categ"]),
                    PrecioCategoria = Convert.ToString(dataReader["precio"]),
                };
                dataReader.Close();
                cBD.Cerrar();
                return objEnt;
            }
            else
            {
                return null;
            }
        }
        public void EliminarCategoria(string ci)
        {
            cBD.Abrir();
            string cadena = "DELETE from categoria where categ =  @categoria";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            comando.Parameters.AddWithValue("@categoria", ci);
            comando.ExecuteNonQuery();
            cBD.Cerrar();

        }

        //eliminar pieza

        public EntidadesPieza BuscarPieza(int id)
        {
            cBD.Abrir();
            string cadena = "SELECT * FROM pieza  WHERE id =" + id;
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();
            if (dataReader.Read())
            {

                EntidadesPieza objEnt = new EntidadesPieza()
                {
                    NombrePieza = Convert.ToString(dataReader["nombre"]),
                    ColorPieza = Convert.ToString(dataReader["color"]),
                    CentroPieza = Convert.ToString(dataReader["centro"]),
                    CategoriaPieza = Convert.ToString(dataReader["categ"]),
                };
                dataReader.Close();
                cBD.Cerrar();
                return objEnt;
            }
            else
            {
                dataReader.Close();
                return null;
            }
        }

        public EntidadesSuministra BuscarPiezaSuministra(int id4)
        {
            cBD.Abrir();
            string cadena = "SELECT * FROM suministra  WHERE id_pieza =" + id4;
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();
            if (dataReader.Read())
            {

                EntidadesSuministra objEnt = new EntidadesSuministra()
                {
                    CantidadSuministra = Convert.ToInt32(dataReader["cantidad"]),
                    IdProveedor = Convert.ToInt32(dataReader["id_proveedor"])
                };
                dataReader.Close();
                cBD.Cerrar();
                return objEnt;
            }
            else
            {
                dataReader.Close();
                return null;

            }
        }
        public void EliminarPieza(int id1)
        {
            cBD.Abrir();
            string cadena = "DELETE from pieza where id = " +id1;
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            comando.ExecuteNonQuery();
            cBD.Cerrar();

        }
    }
}
