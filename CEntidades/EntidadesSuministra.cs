using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class EntidadesSuministra
    {
        public int CantidadSuministra { get; set; }
        public string NombreProveedorSuministra { get; set; }
        public string NombrePiezaSuministra { get; set; }
        public int IdPieza { get; set; }
        public int IdProveedor { get; set; }
    }
}
