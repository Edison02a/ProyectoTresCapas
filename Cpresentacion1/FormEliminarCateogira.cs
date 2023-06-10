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
    public partial class FormEliminarCateogira : Form
    {
        public FormEliminarCateogira()
        {
            InitializeComponent();
        }

        private void FormEliminarCateogira_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet4.categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.proveedorDataSet4.categoria);

        }
        string catego;
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            catego = txt_codbuscar.Text;
            EntidadesCategoria objEntidades = new EntidadesCategoria();
            COperaciones objOpera = new COperaciones();
            try
            {
                if (txt_codbuscar.TextLength < 1)
                {
                    MessageBox.Show("El campo esta vacío", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    objEntidades = objOpera.BuscarCategoria(txt_codbuscar.Text);
                    if (objEntidades != null)
                    {
                        btn_eliminar.Enabled = true;
                        tb_nombre.Text = objEntidades.CategCategoria;
                        tb_precio.Text = objEntidades.PrecioCategoria;
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una categoría con este nombre", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {

                    MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }
        COperaciones objOp = new COperaciones();
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea la categoría " + tb_nombre.Text +" ?"+" \nLas piezas que pertenezcan a esta categoría seran eliminadas", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                objOp.EliminarCategoria(catego);
                MessageBox.Show("Se eliminaron correctamente los datos", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_nombre.Clear();
                tb_precio.Clear();
                tb_nombre.Clear();
                txt_codbuscar.Clear();
                txt_codbuscar.Focus();
                btn_eliminar.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
