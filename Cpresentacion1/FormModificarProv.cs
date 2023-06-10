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
    public partial class FormModificarProv : Form
    {
        public FormModificarProv()
        {
            InitializeComponent();
        }

        private void FormModificarProv_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet6.prov' Puede moverla o quitarla según sea necesario.
            this.provTableAdapter.Fill(this.proveedorDataSet6.prov);

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
        
        private void tb_nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nombre = tb_nombre.Text;


                if (string.IsNullOrEmpty(tb_nombre.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nombre.Focus();
                }
                else
                {
                    if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                    {
                        tb_apellido.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El nombre solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_nombre.Clear();
                        tb_nombre.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void tb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nombre = tb_apellido.Text;


                if (string.IsNullOrEmpty(tb_apellido.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_apellido.Focus();
                }
                else
                {
                    if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                    {
                        tb_direccion.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El apellido solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_apellido.Clear();
                        tb_apellido.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void tb_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string nombre = tb_direccion.Text;


                if (string.IsNullOrEmpty(tb_direccion.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_direccion.Focus();
                }
                else
                {
                    if (Regex.IsMatch(nombre, "^[a-zA-Z\\s]+$"))
                    {
                        //txt_color.Focus();
                    }
                    else
                    {

                        MessageBox.Show("La dirección solo puede contenter letras", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_direccion.Clear();
                        tb_direccion.Focus();
                    }
                }
                //boton_activar();

            }
        }

        private void cmbx_povincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Azuay
            string[] Azuay = { "Cuenca", "Gualaceo", "Azogues", "Paute" };

            // Bolívar
            string[] Bolivar = { "Guaranda", "Chillanes", "San Miguel de Bolívar" };

            // Cañar
            string[] Canar = { "Azogues", "Biblían", "La Troncal", "El Tambo" };

            // Carchi
            string[] Carchi = { "Tulcán", "San Gabriel", "Montúfar" };

            // Chimborazo
            string[] Chimborazo = { "Riobamba", "Guano", "Alausí" };

            // Cotopaxi
            string[] Cotopaxi = { "Latacunga", "Pujilí", "Salcedo" };

            // El Oro
            string[] ElOro = { "Machala", "Santa Rosa", "Pasaje" };

            // Esmeraldas
            string[] Esmeraldas = { "Esmeraldas", "Atacames", "Rioverde" };

            // Galápagos
            string[] Galapagos = { "Puerto Ayora", "Puerto Baquerizo Moreno" };

            // Guayas
            string[] Guayas = { "Guayaquil", "Durán", "Samborondón" };

            // Imbabura
            string[] Imbabura = { "Ibarra", "Otavalo", "Cotacachi" };

            // Loja
            string[] Loja = { "Loja", "Catamayo", "Macará" };

            // Los Ríos
            string[] LosRios = { "Babahoyo", "Quevedo", "Baba" };

            // Manabí
            string[] Manabi = { "Portoviejo", "Manta", "Jipijapa" };

            // Morona Santiago
            string[] MoronaSantiago = { "Macas", "Gualaquiza", "Sucúa" };

            // Napo
            string[] Napo = { "Tena", "El Chaco", "Quijos" };

            // Orellana
            string[] Orellana = { "Orellana", "Coca", "La Joya de los Sachas" };

            // Pastaza
            string[] Pastaza = { "Puyo", "Mera" };

            // Pichincha
            string[] Pichincha = { "Quito", "Cayambe", "Sangolquí" };

            // Santa Elena
            string[] SantaElena = { "Santa Elena", "Salinas", "La Libertad" };

            // Santo Domingo de los Tsáchilas
            string[] SantoDomingo = { "Santo Domingo", "La Concordia" };

            // Sucumbíos
            string[] Sucumbios = { "Lago Agrio", "Nueva Loja" };

            // Tungurahua
            string[] Tungurahua = { "Ambato", "Baños", "Pelileo" };

            // Zamora Chinchipe
            string[] ZamoraChinchipe = { "Zamora", "Yantzaza", "Zumbi" };

            switch (cmbx_povincia.SelectedItem.ToString())

            {
                case "Azuay":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Azuay);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";

                    break;
                case "Bolívar":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Bolivar);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Cañar":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Canar);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Carchi":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Carchi);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Chimborazo":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Chimborazo);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Cotopaxi":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Cotopaxi);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "El Oro":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(ElOro);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = ""; ;
                    break;

                case "Esmeraldas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Esmeraldas);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Galápagos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Galapagos);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Guayas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Guayas);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Imbabura":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Imbabura);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Loja":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Loja);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Los Ríos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(LosRios);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Manabí":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Manabi);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Morona Santiago":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(MoronaSantiago);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Napo":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Napo);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Orellana":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Orellana);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Pastaza":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Pastaza);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Pichincha":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Pichincha);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Santa Elena":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(SantaElena);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Santo Domingo de los Tsáchilas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(SantoDomingo);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Sucumbíos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Sucumbios);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Tungurahua":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Tungurahua);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;
                case "Zamora Chinchipe":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(ZamoraChinchipe);
                    cmbx_ciudad.Enabled = true;
                    cmbx_ciudad.Text = "";
                    break;

                default:
                    MessageBox.Show("Operación no válida");
                    return;
            }
        }
        COperaciones objOpera = new COperaciones();

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Entidades objEntidades = new Entidades();

            try
            {
                try_cedula();
                int ci = Convert.ToInt32(txt_codbuscar.Text);
                objEntidades = objOpera.BuscarId(ci);
                if (objEntidades != null)
                {
                    tb_nombre.Enabled = true;
                    tb_apellido.Enabled = true;
                    tb_direccion.Enabled = true;
                    cmbx_povincia.Enabled = true;
                    cmbx_ciudad.Enabled = true;

                    lbl_cedula.Text = Convert.ToString(objEntidades.CedulaProv);
                    tb_nombre.Text = objEntidades.NombreProv;
                    tb_apellido.Text = objEntidades.ApellidoProv;
                    tb_direccion.Text = objEntidades.DireccionProv;
                    cmbx_povincia.SelectedItem = objEntidades.ProviciaProv;
                    cmbx_ciudad.SelectedItem = objEntidades.CiudadProv;
                    btn_sig.Enabled = true;
                }
                else
                {
                    MessageBox.Show("El proveedor no existe no existe");
                    lbl_cedula.Text = "";
                    tb_nombre.Text = "";
                    tb_apellido.Text = "";
                    tb_direccion.Text = "";
                    cmbx_povincia.Text = "";
                    cmbx_ciudad.Text = "";

                    tb_nombre.Enabled = false;
                    tb_apellido.Enabled = false;
                    tb_direccion.Enabled = false;
                    cmbx_povincia.Enabled = false;
                    cmbx_ciudad.Enabled = false;
                    btn_sig.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {

            if (ValidarCedula(txt_codbuscar.Text) && tb_nombre.TextLength > 0 && tb_apellido.TextLength > 0 && tb_direccion.TextLength > 0 && cmbx_ciudad.SelectedIndex != -1 && cmbx_povincia.SelectedIndex != -1)
            {
                try
                {
                    string nombreP = tb_nombre.Text;
                    string apellido = tb_apellido.Text;
                    string direccion = tb_direccion.Text;
                    string provincia = cmbx_povincia.SelectedItem.ToString();
                    string ciudad = cmbx_ciudad.SelectedItem.ToString();
                    int ciProveedor = Convert.ToInt32(lbl_cedula.Text);

                    objOpera.ActualizarProveedor(ciProveedor, nombreP, apellido, direccion, provincia, ciudad);
                    MessageBox.Show("Los datos se actualizaron correctamente", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Existen campos vacios o incorrectos ", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
