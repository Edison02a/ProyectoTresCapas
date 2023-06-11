using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;
namespace CLogica
{
    public class COperaciones
    {
        CDatos2 ObjDatos = new CDatos2();

        public List<Entidades> Lista()
        {
            return ObjDatos.Obtener();
        }

        public List<EntidadesPieza> Lista2()
        {
            return ObjDatos.Obtener2();
        }

        public List<EntidadesSuministra> Lista3()
        {
            return ObjDatos.Obtener3();
        }

        public List<EntidadesCategoria> Lista4()
        {
            return ObjDatos.Obtener4();
        }

        public void IngresarProveedor(Entidades DatosEstu)
        {
            ObjDatos.registrarProveedor(DatosEstu);

        }

        public void IngresarCategoria(EntidadesCategoria datosCate)
        {
            ObjDatos.registrarCategoria(datosCate);

        }

        public void IngresarPieza(EntidadesPieza datosPieza)
        {
            ObjDatos.registrarPieza(datosPieza);

        }

        public void IngresarPiezaIngresarSuministrar(EntidadesSuministra datosSuministra)
        {
            ObjDatos.registrarSuministrar(datosSuministra);

        }
        public Entidades BuscarId(int ciP)
        {
            return ObjDatos.BuscarId(ciP);
        }
        public void ActualizarCategoria(int idCategoria, string categoria, float precio)
        {
            ObjDatos.ActualizarCategoria(idCategoria, categoria, precio);
        }

        public EntidadesCategoria BuscarCat(string cat)
        {
            return ObjDatos.BuscarCat(cat);
        }
        public List<EntidadesPieza> ObtenerPiezasProveedor(int ciProveedor)
        {
            return ObjDatos.ObtenerPiezasProveedor(ciProveedor);
        }

        /*public EntidadesSuministra BuscarIdS(int ciP)
        {
            return ObjDatos.BuscarIdS(ciP);

        }*/
        public void ActualizarPieza(string nombrePieza, string colorPieza, string centroPieza, string categoriaPieza, int idPieza)
        {
            // Actualizar la pieza en la base de datos
            ObjDatos.ActualizarPieza(nombrePieza, colorPieza, centroPieza, categoriaPieza, idPieza);
        }

        public void ActualizarProveedor(int ciProveedor, string nombreP, string apellido, string direccion, string provincia, string ciudad)
        {
            // Actualizar el proveedor en la base de datos
            ObjDatos.ActualizarProveedor(ciProveedor, nombreP, apellido, direccion, provincia, ciudad);
        }

        public void ActualizarSuministra(int idPieza, int ciProveedor, int cantidadSuministra)
        {
            // Actualizar la cantidad suministrada en la base de datos
            ObjDatos.ActualizarSuministra(idPieza, ciProveedor, cantidadSuministra);
        }

        public Entidades BuscarCedula(int ciPro)
        {

            return ObjDatos.BuscaCedula(ciPro);
        }

        public void EliminarProveedor(int CiPro)
        {

            ObjDatos.EliminarProvedeor(CiPro);
        }

        public EntidadesCategoria BuscarCategoria(string NombreCategoria)
        {

            return ObjDatos.BuscarCategorias(NombreCategoria);
        }

        public void EliminarCategoria(string categ)
        {

            ObjDatos.EliminarCategoria(categ);
        }
        public DataTable BuscarPiezaNombre(string pieza)
        {
            return ObjDatos.BuscarPiezaNombr(pieza);
        }
        public EntidadesPieza BuscarPieza(int id)
        {

            return ObjDatos.BuscarPieza(id);
        }
        public EntidadesSuministra BuscarSuministraPieza(int id3)
        {

            return ObjDatos.BuscarPiezaSuministra(id3);
        }
        public void EliminarPieza(int id2)
        {

            ObjDatos.EliminarPieza(id2);
        }
    }
}
