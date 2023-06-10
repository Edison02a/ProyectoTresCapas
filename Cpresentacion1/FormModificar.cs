using CEntidades;
using CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet1.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet1.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet8.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter1.Fill(this.proveedorDataSet8.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet7.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter.Fill(this.proveedorDataSet7.prov);

            List<Entidades> DatosProveedor = objOpera.Lista();
            foreach (Entidades item in DatosProveedor)
            {
                cb_proveedor.Items.Add(item.NombreProv + " " + item.ApellidoProv + " "+item.CedulaProv);
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
                try_cedula();
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
                    if (cbx_pieza.SelectedIndex != -1)
                    {
                        MostrarDatosPiezaSeleccionada(0);
                    }

                }
                else
                {
                    MessageBox.Show("No se encontraron piezas para el proveedor seleccionado o no existe dicho proveedor.");
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
            int ci = Convert.ToInt32(txt_codbuscar.Text);
            Entidades proveedor = objOpera.BuscarId(ci);
            if (proveedor != null)
            {
                string proveedorConcatenado = proveedor.NombreProv + " " + proveedor.ApellidoProv + " " +proveedor.CedulaProv;
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
            cb_proveedor.SelectedItem= null;
            cbx_pieza.DataSource = null;

            txt_cantidad.Enabled = false;
            txt_centro.Enabled =false;
            txt_color.Enabled =false;
            txt_nombre.Enabled = false;
            cbx_pieza.Enabled = false;
            cb_categoria.Enabled = false;
            cb_proveedor.Enabled = false;
        }

        private void cbx_pieza_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbx_pieza.SelectedIndex != -1)
            {
                int indiceSeleccionado = cbx_pieza.SelectedIndex;
                MostrarDatosPiezaSeleccionada(indiceSeleccionado);
            }
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            if (ValidarCedula(txt_codbuscar.Text) && txt_nombre.TextLength > 0 && txt_color.TextLength > 0 && txt_centro.TextLength > 0 && cb_categoria.SelectedIndex != -1 && cb_proveedor.SelectedIndex != -1)
            {
                try
                {

                    string nombrePieza = txt_nombre.Text;
                    string colorPieza = txt_color.Text;
                    string centroPieza = txt_centro.Text;
                    string categoriaPieza = cb_categoria.SelectedItem.ToString();
                    int idPieza = Convert.ToInt32(lbl_idP.Text);
                    //int ciProveedor1 = Convert.ToInt32(txt_codbuscar.Text);
                    int cantidadSuministra = Convert.ToInt32(txt_cantidad.Text);

                    // Obtener el proveedor seleccionado del combo box

                    string proveedorSeleccionado = cb_proveedor.SelectedItem.ToString();
                    string[] partesProveedor = proveedorSeleccionado.Split(' ');
                    string nombreProveedor = partesProveedor[0];
                    string apellidoProveedor = partesProveedor[1];
                    string ciProveedor = partesProveedor[2];
                    int ciProveedor1 = Convert.ToInt32(ciProveedor);

                    // Llamar al método para actualizar la pieza y el proveedor en la base de datos
                    objOpera.ActualizarPieza(nombrePieza, colorPieza, centroPieza, categoriaPieza, idPieza);
                    //objOpera.ActualizarProveedor(ciProveedor, nombreProveedor, apellidoProveedor);
                    objOpera.ActualizarSuministra(idPieza, ciProveedor1, cantidadSuministra);

                    MessageBox.Show("Datos actualizados correctamente", "Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
                }
            }
            else
            {
                MessageBox.Show("Existen campos vacios o incorrectos ", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        int cedula;
        public bool ValidarCedula(string cedula)
        {
            // Verificar que la cédula tenga 10 dígitos
            if (!Regex.IsMatch(cedula, @"^\d{10}$"))
            {
                return false;
            }

            // Verificar el dígito verificador
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            int total = 0;

            for (int i = 0; i < coeficientes.Length; i++)
            {
                int digito = int.Parse(cedula[i].ToString());
                int producto = digito * coeficientes[i];

                if (producto >= 10)
                {
                    producto -= 9;
                }

                total += producto;
            }

            int digitoVerificador = 10 - (total % 10);
            if (digitoVerificador == 10)
            {
                digitoVerificador = 0;
            }

            return digitoVerificador == int.Parse(cedula[9].ToString());
        }

        public void try_cedula()
        {
            try
            {
                cedula = int.Parse(txt_codbuscar.Text);

                if (ValidarCedula(txt_codbuscar.Text))
                {

                    // tb_nombre.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese una cédula correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_codbuscar.Clear();
                    txt_codbuscar.Focus();
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(txt_codbuscar.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_codbuscar.Focus();
                }
                else
                {
                    string input = txt_codbuscar.Text;
                    bool esNumero = input.All(char.IsDigit);

                    if (!esNumero)
                    {
                        MessageBox.Show("La cédula contiene números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_codbuscar.Clear();
                        txt_codbuscar.Focus();
                    }
                }

            }
        }
        private void txt_codbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                try_cedula();

            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nombre = txt_nombre.Text;


                if (string.IsNullOrEmpty(txt_nombre.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nombre.Focus();
                }
                else
                {
                    if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                    {
                        txt_color.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El nombre solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_nombre.Clear();
                        txt_nombre.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void txt_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string color = txt_color.Text;


                if (string.IsNullOrEmpty(txt_color.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nombre.Focus();
                }
                else
                {
                    if (Regex.IsMatch(color, "^[a-zA-Z\\s]+$"))
                    {
                        txt_centro.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El color solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_color.Clear();
                        txt_color.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void txt_centro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string centro = txt_centro.Text;


                if (string.IsNullOrEmpty(txt_centro.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nombre.Focus();
                }
                else
                {
                    if (Regex.IsMatch(centro, "^[a-zA-Z\\s]+$"))
                    {
                        // txt_color.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El nombre solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_centro.Clear();
                        txt_centro.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                try
                {
                    int cantidad = int.Parse(txt_cantidad.Text);
                }
                catch
                {

                    if (string.IsNullOrEmpty(txt_cantidad.Text))
                    {
                        MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cantidad.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese número enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_cantidad.Clear();
                        txt_cantidad.Focus();
                    }

                }
            }
        }
    }
}
