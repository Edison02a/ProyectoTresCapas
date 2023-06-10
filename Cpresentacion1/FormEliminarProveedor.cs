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
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet9.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet9.prov);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Entidades objEntidades = new Entidades();
            COperaciones objOpera = new COperaciones();
            try

            {
                int idE = Convert.ToInt32(txt_codbuscar.Text);
                objEntidades = objOpera.BuscarCedula(idE);
                if (objEntidades != null)
                {

                    tb_cedula.Text = Convert.ToString(objEntidades.CedulaProv);
                    tb_nombre.Text = objEntidades.NombreProv;
                    tb_apellido.Text = objEntidades.ApellidoProv;
                    tb_direccion.Text = objEntidades.DireccionProv;
                    cmbx_ciudad.Text = objEntidades.CiudadProv;
                    cmbx_povincia.Text = objEntidades.ProviciaProv;
                }
                else

                    MessageBox.Show("El proveedor no existe");

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }

        }
        COperaciones objOp = new COperaciones();

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            objOp.EliminarProveedor(int.Parse(txt_codbuscar.Text));
        }
    }
}
