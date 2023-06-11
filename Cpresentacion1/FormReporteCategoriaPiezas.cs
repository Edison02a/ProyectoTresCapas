using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpresentacion1
{
    public partial class FormReporteCategoriaPiezas : Form
    {
        public FormReporteCategoriaPiezas()
        {
            InitializeComponent();
        }

        private void FormReporteCategoriaPiezas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet34.VistaCantidadPiezasCategoria2' Puede moverla o quitarla según sea necesario.
            this.vistaCantidadPiezasCategoria2TableAdapter.Fill(this.proveedorDataSet34.VistaCantidadPiezasCategoria2);

            this.reportViewer1.RefreshReport();
        }
    }
}
