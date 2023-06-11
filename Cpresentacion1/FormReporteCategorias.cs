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
    public partial class FormReporteCategorias : Form
    {
        public FormReporteCategorias()
        {
            InitializeComponent();
        }

        private void FormReporteCategorias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet29.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.proveedorDataSet29.categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
