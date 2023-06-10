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

        /*public void ActualizarProveedor(int ciProveedor, string nombreProveedor, string apellidoProveedor)
        {
            // Actualizar el proveedor en la base de datos
            ObjDatos.ActualizarProveedor(ciProveedor, nombreProveedor, apellidoProveedor);
        }*/

        public void ActualizarSuministra(int idPieza, int ciProveedor, int cantidadSuministra)
        {
            // Actualizar la cantidad suministrada en la base de datos
            ObjDatos.ActualizarSuministra(idPieza, ciProveedor, cantidadSuministra);
        }

    }
}
