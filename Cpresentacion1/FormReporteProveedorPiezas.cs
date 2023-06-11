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
    public partial class FormReporteProveedorPiezas : Form
    {
        public FormReporteProveedorPiezas()
        {
            InitializeComponent();
        }

        private void FormReporteProveedorPiezas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet32.VistaCantidadPiezasProveedor' Puede moverla o quitarla según sea necesario.
            this.vistaCantidadPiezasProveedorTableAdapter.Fill(this.proveedorDataSet32.VistaCantidadPiezasProveedor);

            this.reportViewer1.RefreshReport();
        }
    }
}
