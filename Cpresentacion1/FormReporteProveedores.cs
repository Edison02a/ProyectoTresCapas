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
    public partial class FormReporteProveedores : Form
    {
        public FormReporteProveedores()
        {
            InitializeComponent();
        }

        private void FormReporteProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet28.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet28.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet1.prov' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
        }
    }
}
