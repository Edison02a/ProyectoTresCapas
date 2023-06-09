using CEntidades;
using CLogica;
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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet3.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter1.Fill(this.proveedorDataSet3.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet2.prov' Puede moverla o quitarla según sea necesario.
            List<Entidades> DatosProveedor = objOpera.Lista();
            foreach (Entidades item in DatosProveedor)
            {
                cb_proveedor.Items.Add(item.NombreProv + " " + item.ApellidoProv);
            }


            List<EntidadesCategoria> datosCategoria = objOpera.Lista4();
            foreach (EntidadesCategoria item in datosCategoria)
            {
                cb_categoria.Items.Add(item.CategCategoria);
            }

        }
        COperaciones objOpera = new COperaciones();
        Entidades objEntidades = new Entidades();
        EntidadesSuministra objSumi = new EntidadesSuministra();
        EntidadesPieza objPieza = new EntidadesPieza();
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int ci = Convert.ToInt32(txt_codbuscar.Text);
                objEntidades = objOpera.BuscarId(ci);
                if (objEntidades != null)
                {
                    cb_proveedor.SelectedItem= objEntidades.NombreProv + objEntidades.ApellidoProv;
                    cb_proveedor.SelectedItem = objEntidades.NombreProv.ToString();
                    
                    //lbl_codigo.Text = Convert.ToString(objEntidades.idEst);
                    //lbl_nombre.Text = objEntidades.NombreEst;
                    //lbl_apellido.Text = objEntidades.ApellidoEst;
                }
                else
                    MessageBox.Show("El estudiante no existe");
                objPieza = objOpera.BuscarIdP(ci);
                if (objPieza != null)
                {
                    txt_nombre.Text = Convert.ToString(objPieza.NombrePieza);
                    txt_color.Text = Convert.ToString(objPieza.ColorPieza);
                    txt_centro.Text = Convert.ToString(objPieza.CentroPieza);
                    cb_categoria.SelectedItem = objPieza.CategoriaPieza.ToString();
                    

                    
                    //lbl_codigo.Text = Convert.ToString(objEntidades.idEst);
                    //lbl_nombre.Text = objEntidades.NombreEst;
                    //lbl_apellido.Text = objEntidades.ApellidoEst;
                }
                else
                    MessageBox.Show("El estudiante no existe");

                objSumi = objOpera.BuscarIdS(ci);
                if (objPieza != null)
                {
                    txt_cantidad.Text = Convert.ToString(objSumi.CantidadSuministra);

                    //lbl_codigo.Text = Convert.ToString(objEntidades.idEst);
                    //lbl_nombre.Text = objEntidades.NombreEst;
                    //lbl_apellido.Text = objEntidades.ApellidoEst;
                }
                else
                    MessageBox.Show("El estudiante no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {

        }
    }
}
