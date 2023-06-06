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
    }
}
