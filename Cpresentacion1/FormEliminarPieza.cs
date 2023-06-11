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
    public partial class FormEliminarPieza : Form
    {
        public FormEliminarPieza()
        {
            InitializeComponent();
        }

        private void FormEliminarPieza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet17.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter3.Fill(this.proveedorDataSet17.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet16.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter2.Fill(this.proveedorDataSet16.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet15.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter1.Fill(this.proveedorDataSet15.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet8.pieza' Puede moverla o quitarla según sea necesario.
            this.piezaTableAdapter.Fill(this.proveedorDataSet8.pieza);

        }
        int pieza;
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            EntidadesPieza objEntidades = new EntidadesPieza();
            EntidadesSuministra obSumi = new EntidadesSuministra();
            COperaciones objOpera = new COperaciones();
            try
            {
                pieza = int.Parse(txt_codbuscar.Text);
                if (txt_codbuscar.TextLength < 1)
                {
                    MessageBox.Show("El campo esta vacío", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
  
                    objEntidades = objOpera.BuscarPieza(pieza);

                    if (objEntidades != null)
                    {
                        btn_eliminar.Enabled = true;
                        tb_nombre.Text = objEntidades.NombrePieza;
                        tb_color.Text = objEntidades.ColorPieza;
                        tb_centro.Text = objEntidades.CentroPieza;
                        tb_categoria.Text = objEntidades.CategoriaPieza;
                        obSumi = objOpera.BuscarSuministraPieza(pieza);
                        if (obSumi != null)
                        {
                            tb_cantidad.Text = obSumi.CantidadSuministra.ToString();
                            tb_proveedor.Text = obSumi.IdProveedor.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontro una pieza con ese id", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                string input = txt_codbuscar.Text;
                bool esNumero = input.All(char.IsDigit);
                if (!esNumero)
                {
                    MessageBox.Show("El id de las piesas son números enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_codbuscar.Clear();
                    txt_codbuscar.Focus();
                }
                else
                {
                    if (txt_codbuscar.TextLength < 1)
                    {
                        MessageBox.Show("El campo esta vacío", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");

                    }
                }
            }
        }
        COperaciones objOp = new COperaciones();
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar la pieza" + tb_nombre.Text + "?\nSe eliminaran: "+tb_cantidad.Text ,"Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                objOp.EliminarPieza(int.Parse(txt_codbuscar.Text));
                MessageBox.Show("Se eliminaron correctamente los datos", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_cantidad.Clear();
                tb_categoria.Clear();
                tb_nombre.Clear();
                tb_centro.Clear();
                tb_color.Clear();
                txt_codbuscar.Clear();
                txt_codbuscar.Focus();
                btn_eliminar.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
