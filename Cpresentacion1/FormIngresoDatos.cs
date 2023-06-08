using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEntidades;
using CLogica;
using ComponentFactory.Krypton.Toolkit;

namespace Cpresentacion1
{
    public partial class FormIngresoDatos : KryptonForm
    {

        public FormIngresoDatos()
        {
            InitializeComponent();
        }

        private void FormIngresoDatos_Load(object sender, EventArgs e)
        {
            tb_nombre.Focus();
        }

        private void cmbx_pres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void btn_sig_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades proveedordatos = new Entidades();
                proveedordatos.NombreProv = tb_nombre.Text;
                proveedordatos.ApellidoProv = tb_apellido.Text;
                proveedordatos.DireccionProv = tb_direccion.Text;
                proveedordatos.CiudadProv = cmbx_ciudad.SelectedItem.ToString();
                proveedordatos.ProviciaProv = cmbx_povincia.SelectedItem.ToString();
                COperaciones operaciones = new COperaciones();
                operaciones.IngresarProveedor(proveedordatos);
                MessageBox.Show("Los datos se guardaron correctamente", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }



        private void boton_activar()
        {
            if (tb_direccion.TextLength > 0 && tb_nombre.TextLength > 0 && cmbx_ciudad.SelectedIndex != -1 && cmbx_povincia.SelectedIndex != -1)
            {
                btn_sig.Enabled = true;
            }
        }
        string nombre, ciudad, provincia,direccion,apellido;

        private void FormIngresoDatos_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void kryptonGroup1_MouseMove(object sender, MouseEventArgs e)
        {
            boton_activar();
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

                    break;
                case "Bolívar":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Bolivar);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Cañar":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Canar);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Carchi":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Carchi);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Chimborazo":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Chimborazo);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Cotopaxi":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Cotopaxi);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "El Oro":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(ElOro);
                    cmbx_ciudad.Enabled = true;
                    break;

                case "Esmeraldas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Esmeraldas);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Galápagos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Galapagos);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Guayas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Guayas);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Imbabura":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Imbabura);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Loja":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Loja);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Los Ríos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(LosRios);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Manabí":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Manabi);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Morona Santiago":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(MoronaSantiago);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Napo":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Napo);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Orellana":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Orellana);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Pastaza":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Pastaza);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Pichincha":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Pichincha);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Santa Elena":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(SantaElena);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Santo Domingo de los Tsáchilas":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(SantoDomingo);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Sucumbíos":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Sucumbios);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Tungurahua":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(Tungurahua);
                    cmbx_ciudad.Enabled = true;
                    break;
                case "Zamora Chinchipe":
                    cmbx_ciudad.Items.Clear();
                    cmbx_ciudad.Items.AddRange(ZamoraChinchipe);
                    cmbx_ciudad.Enabled = true;
                    break;

                default:
                    MessageBox.Show("Operación no válida");
                    return;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                apellido = tb_apellido.Text;


                if (string.IsNullOrEmpty(tb_nombre.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_apellido.Focus();
                }
                else
                {
                    if (Regex.IsMatch(apellido, "^[a-zA-Z\\s]+$"))
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
                boton_activar();

            }
        }

        private void tb_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                 direccion = tb_direccion.Text;


                if (string.IsNullOrEmpty(tb_direccion.Text))
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_direccion.Focus();
                }
                else
                {
                    if (Regex.IsMatch(direccion, "^[a-zA-Z0-9\\s]+$"))
                    {
                        
                    }
                    else
                    {

                        MessageBox.Show("La dirección no puede contenter caracteres especiales", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_direccion.Clear();
                        tb_direccion.Focus();
                    }
                }

            }
        }

        private void tb_direccion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                     nombre = tb_nombre.Text;


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
                boton_activar();

            }
        }
    }
}
