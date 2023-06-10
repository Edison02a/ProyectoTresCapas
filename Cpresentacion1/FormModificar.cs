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
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet5.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet5.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet4.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter1.Fill(this.proveedorDataSet3.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet3.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter1.Fill(this.proveedorDataSet3.prov);
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
        /*COperaciones objOpera = new COperaciones();
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
                    txt_cantidad.Enabled = true;
                    txt_centro.Enabled = true;
                    txt_color.Enabled = true;
                    txt_nombre.Enabled = true;
                    cbx_pieza.Enabled = true;
                    cb_categoria.Enabled = true;
                    cb_proveedor.Enabled = true;
                   
                    string proveedorConcatenado = objEntidades.NombreProv.ToString() + " " + objEntidades.ApellidoProv.ToString();
                    cb_proveedor.SelectedItem = proveedorConcatenado;
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
                   
                }
                else
                    MessageBox.Show("El estudiante no existe");

                objSumi = objOpera.BuscarIdS(ci);
                if (objPieza != null)
                {
                    txt_cantidad.Text = Convert.ToString(objSumi.CantidadSuministra);

                }
                else
                    MessageBox.Show("El estudiante no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }*/

        //COperaciones objOpera = new COperaciones();
        Entidades objEntidades = new Entidades();
        EntidadesSuministra objSumi = new EntidadesSuministra();
        EntidadesPieza objPieza = new EntidadesPieza();
        COperaciones objOpera = new COperaciones();
        List<EntidadesPieza> listaPiezas = new List<EntidadesPieza>();
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                int ci = Convert.ToInt32(txt_codbuscar.Text);
                listaPiezas = objOpera.ObtenerPiezasProveedor(ci);

                if (listaPiezas.Count > 0)
                {
                    txt_cantidad.Enabled = true;
                    txt_centro.Enabled = true;
                    txt_color.Enabled = true;
                    txt_nombre.Enabled = true;
                    cbx_pieza.Enabled = true;
                    cb_categoria.Enabled = true;
                    cb_proveedor.Enabled = true;

                    // Cargar el ComboBox con las piezas del proveedor
                    cbx_pieza.DataSource = listaPiezas;
                    cbx_pieza.DisplayMember = "NombrePieza";
                    cbx_pieza.ValueMember = "NombrePieza";

                    // Mostrar la primera pieza en los TextBox y ComboBox
                    MostrarDatosPiezaSeleccionada(0);
                }
                else
                {
                    MessageBox.Show("No se encontraron piezas para el proveedor seleccionado.");
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void MostrarDatosPiezaSeleccionada(int indice)
        {
            EntidadesPieza piezaSeleccionada = listaPiezas[indice];
            
            txt_nombre.Text = piezaSeleccionada.NombrePieza;
            lbl_idP.Text = Convert.ToString( piezaSeleccionada.IdPieza);
            txt_color.Text = piezaSeleccionada.ColorPieza;
            txt_centro.Text = piezaSeleccionada.CentroPieza;
            cb_categoria.SelectedItem = piezaSeleccionada.CategoriaPieza;
            txt_cantidad.Text = Convert.ToString( piezaSeleccionada.CantidadSuministrada);

            Entidades proveedor = objOpera.BuscarId(ci);
            if (proveedor != null)
            {
                string proveedorConcatenado = proveedor.NombreProv + " " + proveedor.ApellidoProv;
                cb_proveedor.SelectedItem = proveedorConcatenado;
            }

        }

        private void LimpiarCampos()
        {
            txt_nombre.Text = "";
            txt_color.Text = "";
            txt_centro.Text = "";
            lbl_idP.Text = "";
            cb_categoria.SelectedItem = null;
            txt_cantidad.Text = "";
            cbx_pieza.DataSource = null;
        }

        private void cbx_pieza_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indiceSeleccionado = cbx_pieza.SelectedIndex;
            MostrarDatosPiezaSeleccionada(indiceSeleccionado);
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePieza = txt_nombre.Text;
                string colorPieza = txt_color.Text;
                string centroPieza = txt_centro.Text;
                string categoriaPieza = cb_categoria.SelectedItem.ToString();
                int idPieza= Convert.ToInt32(lbl_idP.Text);
                int ciProveedor = Convert.ToInt32(txt_codbuscar.Text);
                int cantidadSuministra = Convert.ToInt32(txt_cantidad.Text);

                objOpera.ActualizarPieza(nombrePieza, colorPieza, centroPieza, categoriaPieza, idPieza ,ciProveedor, cantidadSuministra);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }

        }
    }
}
