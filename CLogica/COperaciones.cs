using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;
namespace CLogica
{
    public  class COperaciones
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
    }
}
