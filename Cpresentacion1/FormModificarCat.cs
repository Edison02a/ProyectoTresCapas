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
    public partial class FormModificarCat : Form
    {
        public FormModificarCat()
        {
            InitializeComponent();
        }

        private void FormModificarCat_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet22.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.proveedorDataSet22.categoria);
            

        }
   
        COperaciones objOpera = new COperaciones();
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            EntidadesCategoria objCat = new EntidadesCategoria();
            
            try
            {
                
                string cate = txt_codbuscar.Text;


                if (string.IsNullOrEmpty(txt_codbuscar.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_codbuscar.Focus();
                }
                else
                {
                    if (Regex.IsMatch(cate, "^[a-zA-Z\\s]+$"))
                    {
                        string cat = txt_codbuscar.Text;
                        objCat = objOpera.BuscarCat(cat);
                        if (objCat != null)
                        {
                            tb_categoria.Enabled = true;
                            tb_precio.Enabled = true;


                            lbl_idcat.Text = Convert.ToString(objCat.IdCateogoria);
                            tb_categoria.Text = objCat.CategCategoria;
                            tb_precio.Text = objCat.PrecioCategoria;

                            btn_sig.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("La categoria no existe no existe");
                            lbl_idcat.Text = "";
                            tb_categoria.Text = "";
                            tb_precio.Text = "";


                            tb_categoria.Enabled = false;
                            tb_precio.Enabled = false;

                            btn_sig.Enabled = false;
                        }
                    }
                    else
                    {

                        MessageBox.Show("El nombre solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_codbuscar.Clear();
                        txt_codbuscar.Focus();
                        
                    }
                }

                //string cat = txt_codbuscar.Text;
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            if (tb_categoria.TextLength > 0 && tb_precio.TextLength > 0)
            {
                try
                {
                    string categoria = tb_categoria.Text;
                    float precio = float.Parse(tb_precio.Text);

                    int idcat = Convert.ToInt32(lbl_idcat.Text);

                    objOpera.ActualizarCategoria(idcat, categoria, precio);
                    MessageBox.Show("Los datos se actualizaron correctamente", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    if (ex.Message.Contains("UNIQUE"))
                    {
                        MessageBox.Show("Error: Ya existe una categoría con ese nombre", "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Existen campos vacios o incorrectos ", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    float precio = float.Parse(tb_precio.Text);
                    string input = tb_precio.Text;
                    Regex regex = new Regex(@"^\d+(\.\d{1,2})?$");

                    if (!regex.IsMatch(input))
                    {
                        tb_precio.Clear();
                        tb_precio.Focus();
                        MessageBox.Show("El precio puede contener hasta 2 decimales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch
                {
                    MessageBox.Show("Ingrese el precio en números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_precio.Focus();
                }


            }
        }

        private void tb_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nombre = tb_categoria.Text;


                if (string.IsNullOrEmpty(tb_categoria.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_categoria.Focus();
                }
                else
                {
                    if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                    {
                        tb_precio.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El nombre solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_categoria.Clear();
                        tb_categoria.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
