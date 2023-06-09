using System;
using System.Collections.Generic;
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
                        NombreProv = Convert.ToString(sqlreader["Nombre"]),
                        ApellidoProv = Convert.ToString(sqlreader["Apellido"]),
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
            string cadena = "select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = " + ciPr + "";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {
                Entidades objEnt = new Entidades()
                {
                    //CedulaProv = Convert.ToInt32(dataReader["ci"]),
                    NombreProv = Convert.ToString(dataReader["nombre"]),
                    ApellidoProv = Convert.ToString(dataReader["apellido"]),
                    /*DireccionProv = Convert.ToString(dataReader["direccion"]),
                    CiudadProv = Convert.ToString(dataReader["ciudad"]),
                    ProviciaProv = Convert.ToString(dataReader["provincia"])*/
                    //NombreEst = Convert.ToString(dataReader["Nombre"]),
                    //ApellidoEst = Convert.ToString(dataReader["Apellido"])
                };
               
                /*select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = '1805097217*/
                /* EntidadesCategoria objCategoria = new EntidadesCategoria()
                 {
                     CategCategoria= Convert.ToString(dataReader["categ"]),
                     //PrecioCategoria = Convert.ToString(dataReader["precio"]),

                 };*/
                EntidadesPieza objPieza = new EntidadesPieza()
                {
                    NombrePieza = Convert.ToString(dataReader["nombre"]),
                    ColorPieza = Convert.ToString(dataReader["color"]),
                    CentroPieza = Convert.ToString(dataReader["centro"]),
                    CategoriaPieza= Convert.ToString(dataReader["categ"])
                };

                EntidadesSuministra objSumi = new EntidadesSuministra()
                {
                    CantidadSuministra= Convert.ToInt32(dataReader["cantidad"]),
                };
                dataReader.Close();
                return objEnt;
            }
            else
            {
                return null;
            }
        }


        public EntidadesPieza BuscarIdP(int ciPr)
        {
            cBD.Abrir();
            string cadena = "select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = " + ciPr + "";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {
                

                /*select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = '1805097217*/
                /* EntidadesCategoria objCategoria = new EntidadesCategoria()
                 {
                     CategCategoria= Convert.ToString(dataReader["categ"]),
                     //PrecioCategoria = Convert.ToString(dataReader["precio"]),

                 };*/
                EntidadesPieza objPieza = new EntidadesPieza()
                {
                    NombrePieza = Convert.ToString(dataReader["nombre"]),
                    ColorPieza = Convert.ToString(dataReader["color"]),
                    CentroPieza = Convert.ToString(dataReader["centro"]),
                    CategoriaPieza = Convert.ToString(dataReader["categ"])
                };

                EntidadesSuministra objSumi = new EntidadesSuministra()
                {
                    CantidadSuministra = Convert.ToInt32(dataReader["cantidad"]),
                };
                dataReader.Close();
                return objPieza;
            }
            else
            {
                return null;
            }
        }

        public EntidadesSuministra BuscarIdS(int ciPr)
        {
            cBD.Abrir();
            string cadena = "select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = " + ciPr + "";
            SqlCommand comando = new SqlCommand(cadena, cBD.conectar);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            SqlDataReader dataReader = comando.ExecuteReader();

            if (dataReader.Read())
            {


                /*select P.nombre,P.color,P.centro,P.categ,Pr.nombre,Pr.apellido,S.cantidad from prov Pr inner join suministra S on Pr.ci = S.id_proveedor inner join pieza P on P.id = S.id_pieza inner join categoria C on C.id = P.id where Pr.ci = '1805097217*/
                /* EntidadesCategoria objCategoria = new EntidadesCategoria()
                 {
                     CategCategoria= Convert.ToString(dataReader["categ"]),
                     //PrecioCategoria = Convert.ToString(dataReader["precio"]),

                 };*/
               

                EntidadesSuministra objSumi = new EntidadesSuministra()
                {
                    CantidadSuministra = Convert.ToInt32(dataReader["cantidad"]),
                };
                dataReader.Close();
                return objSumi;
            }
            else
            {
                return null;
            }
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
