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
    public partial class FormReportePiezas : Form
    {
        public FormReportePiezas()
        {
            InitializeComponent();
        }

        private void FormReportePiezas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet14.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter.Fill(this.proveedorDataSet14.pieza);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
