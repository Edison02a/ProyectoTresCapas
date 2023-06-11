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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cpresentacion1
{
    public partial class FormEliminarProveedor : Form
    {
        public FormEliminarProveedor()
        {
            InitializeComponent();
        }

        private void FormEliminarProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet11.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter3.Fill(this.proveedorDataSet11.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet5.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter2.Fill(this.proveedorDataSet5.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet3.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter1.Fill(this.proveedorDataSet3.prov);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet9.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter.Fill(this.proveedorDataSet9.prov);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Entidades objEntidades = new Entidades();
            COperaciones objOpera = new COperaciones();
            try

            {
                int idE = int.Parse(txt_codbuscar.Text);
                objEntidades = objOpera.BuscarCedula(idE);
                if (objEntidades != null)
                {

                    tb_cedula.Text = Convert.ToString(objEntidades.CedulaProv);
                    tb_nombre.Text = objEntidades.NombreProv;
                    tb_apellido.Text = objEntidades.ApellidoProv;
                    tb_direccion.Text = objEntidades.DireccionProv;
                    cmbx_ciudad.Text = objEntidades.CiudadProv;
                    cmbx_povincia.Text = objEntidades.ProviciaProv;
                    btn_eliminar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró un proveedor con esa cédula", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_codbuscar.Focus();
                }

            }
            catch (Exception ex)
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
        COperaciones objOp = new COperaciones();

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea eliminar el proveedor " + tb_nombre.Text + " " + tb_apellido.Text + " " + tb_cedula.Text + "? \n\nSe eliminarán las piesas de este ditribuidor\nRecomendación: Cambiar de proveedor las piezas", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                objOp.EliminarProveedor(int.Parse(txt_codbuscar.Text));
                MessageBox.Show("Se eliminaron correctamente los datos", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_cedula.Clear();
                tb_apellido.Clear();
                tb_nombre.Clear();
                tb_direccion.Clear();
                cmbx_ciudad.Clear();
                cmbx_povincia.Clear();
                txt_codbuscar.Clear();
                txt_codbuscar.Focus();
                btn_eliminar.Enabled = false;
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void kryptonGroup1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
