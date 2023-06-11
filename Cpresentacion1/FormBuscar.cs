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
    public partial class FormBuscar : Form
    {
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void cb_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cb_codigo_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_codigo.Checked)
            {
                dataGridView4.Visible = true;
                dataGridView4.Dock= DockStyle.Fill;
                dataGridView5.Visible = false;
                dataGridView6.Visible = false;
                cb_categoria.Checked = false;
                cb_nombre.Checked = false;
                txt_buscar.Enabled = true;
                btn_buscar.Enabled = true;
                lbl_campo.Text = "Cédula:";
                txt_buscar.Focus();
            }
            
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet25.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.proveedorDataSet25.categoria);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet24.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter.Fill(this.proveedorDataSet24.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet23.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet23.prov);

        }

        private void cb_nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nombre.Checked)
            {
                dataGridView5.Visible = true;
                dataGridView5.Dock = DockStyle.Fill;
                dataGridView4.Visible = false;
                dataGridView6.Visible = false;
                cb_codigo.Checked = false;
                cb_categoria.Checked = false;
                txt_buscar.Enabled = true;
                btn_buscar.Enabled = true;
                lbl_campo.Text = "Pieza:";
                txt_buscar.Focus();
            }
        }

        private void cb_categoria_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_categoria.Checked)
            {
                dataGridView6.Visible = true;
                dataGridView6.Dock = DockStyle.Fill;
                dataGridView4.Visible = false;
                dataGridView5.Visible = false;
                cb_codigo.Checked = false;
                cb_nombre.Checked = false;
                txt_buscar.Enabled = true;
                btn_buscar.Enabled = true;
                lbl_campo.Text = "Categoría:";
                txt_buscar.Focus();
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
                cedula = int.Parse(txt_buscar.Text);

                if (ValidarCedula(txt_buscar.Text))
                {

                    // tb_nombre.Focus();
                }
                else
                {
                    MessageBox.Show("Ingrese una cédula correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_buscar.Clear();
                    txt_buscar.Focus();
                }
            }
            catch
            {
                if (string.IsNullOrEmpty(txt_buscar.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_buscar.Focus();
                }
                else
                {
                    string input = txt_buscar.Text;
                    bool esNumero = input.All(char.IsDigit);

                    if (!esNumero)
                    {
                        MessageBox.Show("La cédula contiene números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_buscar.Clear();
                        txt_buscar.Focus();
                    }
                }

            }
        }
        COperaciones objOpera = new COperaciones();
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (lbl_campo.Text == "Cédula:")
            {
                dataGridView1.Visible = true;
                dataGridView1.Dock = DockStyle.Fill;
                try_cedula();
                Entidades objEntidades = new Entidades();
                int ci = Convert.ToInt32(txt_buscar.Text);
                objEntidades = objOpera.BuscarId(ci);

                if (objEntidades != null)
                {
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false; 
                    
                    dataGridView1.Rows.Clear();
                    
                    dataGridView1.Dock = DockStyle.Fill;
                    // Agregar una nueva fila al DataGridView con los datos del proveedor
                    dataGridView1.Rows.Add(objEntidades.CedulaProv, objEntidades.NombreProv, objEntidades.ApellidoProv, objEntidades.DireccionProv, objEntidades.ProviciaProv, objEntidades.CiudadProv);
                }
                else
                {
                    // El proveedor no fue encontrado, mostrar un mensaje de error o realizar la acción correspondiente
                    MessageBox.Show("Proveedor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (lbl_campo.Text == "Pieza:")
                {
                    dataGridView2.Visible = true;
                    dataGridView2.Dock = DockStyle.Fill;
                    string nombre = txt_buscar.Text;


                    if (string.IsNullOrEmpty(txt_buscar.Text))
                    {
                        MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_buscar.Focus();
                    }
                    else
                    {
                        if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                        {
                            dataGridView2.Visible = true;
                            dataGridView1.Visible = false;
                            dataGridView3.Visible = false;
                            dataGridView2.Dock = DockStyle.Fill;
                            dataGridView2.DataSource = null;
                            string pieza = txt_buscar.Text;

                            // Llamar al método de la capa lógica para buscar la categoría
                            DataTable dataTable = objOpera.BuscarPiezaNombre(pieza);

                            if (dataTable != null)
                            {
                                // Mostrar los datos en el DataGridView
                                dataGridView2.DataSource = dataTable;

                            }
                            else
                            {
                                // El proveedor no fue encontrado, mostrar un mensaje de error o realizar la acción correspondiente
                                MessageBox.Show("Pieza no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {

                            MessageBox.Show("Sólo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_buscar.Clear();
                            txt_buscar.Focus();
                        }
                    }
                }
                else
                {
                    if (lbl_campo.Text == "Categoría:")
                    {
                        dataGridView3.Visible = true;
                        dataGridView3.Dock = DockStyle.Fill;
                        string nombre = txt_buscar.Text;


                    if (string.IsNullOrEmpty(txt_buscar.Text))
                    {
                        MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_buscar.Focus();
                    }
                    else
                    {
                        if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                        {

                                EntidadesCategoria objCat = new EntidadesCategoria();
                                
                                string cat = txt_buscar.Text;
                                
                                objCat = objOpera.BuscarCat(cat);

                                if (objCat != null)
                                {
                                    dataGridView3.Visible = true;
                                    dataGridView1.Visible = false;
                                    dataGridView2.Visible = false;
                                    dataGridView3.Dock = DockStyle.Fill;
                                    dataGridView3.Rows.Clear();
                                    
                                    // Agregar una nueva fila al DataGridView con los datos del proveedor
                                    dataGridView3.Rows.Add(Convert.ToString(objCat.IdCateogoria), objCat.CategCategoria, objCat.PrecioCategoria);
                                }
                                else
                                {
                                    // El proveedor no fue encontrado, mostrar un mensaje de error o realizar la acción correspondiente
                                    MessageBox.Show("Categoríra no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                        else
                        {

                            MessageBox.Show("Sólo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_buscar.Clear();
                            txt_buscar.Focus();
                        }
                    }
                    }
                }
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
