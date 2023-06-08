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
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.suministra' Puede moverla o quitarla según sea necesario.
            //this.suministraTableAdapter.Fill(this.proveedorDataSet.suministra);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.pieza' Puede moverla o quitarla según sea necesario.
            // this.piezaTableAdapter.Fill(this.proveedorDataSet.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter.Fill(this.proveedorDataSet.prov);

            List<Entidades> DatosProveedor = objOpera.Lista();
            string proveedor;
            foreach (Entidades item in DatosProveedor)
            {
                ComboBox1.Items.Add(item.NombreProv);
            }

            List<EntidadesPieza> DatosPieza = objOpera.Lista2();
            foreach (EntidadesPieza item in DatosPieza)
            {
                ComboBox2.Items.Add(item.NombrePieza);
            }

            List<EntidadesSuministra> DatosSuministra = objOpera.Lista3();
            foreach (EntidadesSuministra item in DatosSuministra)
            {
                ComboBox3.Items.Add(item.CantidadSuministra);
            }


            List<EntidadesCategoria> datosCategoria = objOpera.Lista4();
            foreach (EntidadesCategoria item in datosCategoria)
            {
                ComboBox4.Items.Add(item.CategCategoria);
            }

            panel_agregar.Visible = false;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(panel_agregar.Visible)
            {
                panel_agregar.Visible = false;
            }
            else
            {
                panel_agregar.Visible = true;
            }
        }

        private Form currentForm = null;
        private void OpenchildForm(Form hijo)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            //hijo.BackColor = Color.FromArgb(32, 52, 68);
            panel_conten.Controls.Add(hijo);
            panel_conten.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_pieza_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoDatos());
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoPiezas());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoCategoria());  
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_conten_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
