using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CEntidades;
using CLogica;
namespace Cpresentacion1
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        COperaciones objOpera = new COperaciones();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter.Fill(this.proveedorDataSet.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet.prov);

            List<Entidades> DatosProveedor = objOpera.Lista();
            foreach (Entidades item in DatosProveedor)
            {
                listBox1.Items.Add(item.NombreProv);
            }

            List<EntidadesPieza> DatosPieza = objOpera.Lista2();
            foreach (EntidadesPieza item in DatosPieza)
            {
                listBox2.Items.Add(item.NombrePieza);
            }

        }
    }
}
