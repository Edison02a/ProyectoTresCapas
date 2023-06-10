using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using CEntidades;
using CLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Contracts;

namespace Cpresentacion1
{
    public partial class Form1 : KryptonForm
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        COperaciones objOpera = new COperaciones();
        private void Form1_Load_1(object sender, EventArgs e)
        {
            panel_modificar.Visible = false;
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.suministra' Puede moverla o quitarla según sea necesario.
            //this.suministraTableAdapter.Fill(this.proveedorDataSet.suministra);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.pieza' Puede moverla o quitarla según sea necesario.
            // this.piezaTableAdapter.Fill(this.proveedorDataSet.pieza);
            // TODO: esta línea de código carga datos en la tabla 'proveedorDataSet.prov' Puede moverla o quitarla según sea necesario.
            //this.provTableAdapter.Fill(this.proveedorDataSet.prov);

            List<Entidades> DatosProveedor = objOpera.Lista();
            string proveedor;
            /*foreach (Entidades item in DatosProveedor)
            {
                //ComboBox1.Items.Add(item.NombreProv);
            }*/

            List<EntidadesPieza> DatosPieza = objOpera.Lista2();
            /*foreach (EntidadesPieza item in DatosPieza)
            {
                //ComboBox2.Items.Add(item.NombrePieza);
            }*/

            List<EntidadesSuministra> DatosSuministra = objOpera.Lista3();
            /*foreach (EntidadesSuministra item in DatosSuministra)
            {
                //ComboBox3.Items.Add(item.CantidadSuministra);
            }*/


            List<EntidadesCategoria> datosCategoria = objOpera.Lista4();
            /*foreach (EntidadesCategoria item in datosCategoria)
            {
                //ComboBox4.Items.Add(item.CategCategoria);
            }*/

            panel_agregar.Visible = false;
            btn_agregar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_eliminar.Enabled = false;
            panel_eliminar.Visible = false;

            panel_modificar.Visible = false;
          
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
            panel_agregar.BringToFront();
            panel_modificar.Visible = false;
            //panel_reporteAdmin.Visible = false;
            if (panel_agregar.Visible)
            {
                panel_agregar.Visible = false;
            }
            else
            {
                panel_agregar.Size = new System.Drawing.Size(277, 36);
                panel_agregar.Visible = true;

            }
        }

        private Form currentForm = null;
        private void OpenchildForm(Form hijo)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            //hijo.BackColor = Color.FromArgb(32, 52, 68);
            panel_conten.Controls.Add(hijo);
            panel_conten.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_pieza_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoDatos());
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoPiezas());
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormIngresoCategoria());  
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_conten_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            panel_modificar.BringToFront();
            panel_agregar.Visible = false;
            //panel_reporteAdmin.Visible = false;
            if (panel_modificar.Visible)
            {
                panel_modificar.Visible = false;
            }
            else
            {
                panel_modificar.Size = new System.Drawing.Size(183, 36);
                panel_modificar.Visible = true;

            }
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormModificar());
            panel_modificar.Visible = false;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (tb_usuario.TextLength < 1 || tb_contra.TextLength < 1)
            {
                MessageBox.Show("Existen campos vacio", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //verificar correo si no presiona enter
                correo = tb_usuario.Text; // Obtener el valor del TextBox
                bool terminaEnCorreoValido = correo.EndsWith("@gmail.com") ||
                                             correo.EndsWith("@hotmail.com") ||
                                             correo.EndsWith("@hotmail.es") ||
                                             correo.EndsWith("@yahoo.com") ||
                                             correo.EndsWith("@espoch.edu.ec") ||
                                             correo.EndsWith("@outlook.com") ||
                                             correo.EndsWith("@outlook.es");
                if (terminaEnCorreoValido)
                {
                   
                }
                else
                {
                    tb_usuario.Clear();
                    MessageBox.Show("El correo electrónico no tiene un formato válido", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //fin verificacion correo

                //verificar contraseña si no presiona enter


                //fin verificacion
                if ((tb_usuario.Text == "a2@gmail.com" && tb_contra.Text == "admin2") || (tb_usuario.Text == "a1@gmail.com" && tb_contra.Text == "admin1"))
                {
                    btn_eliminar.Enabled = true;
                    btn_agregar.Enabled = true;
                    btn_modificar.Enabled = true;
                    MessageBox.Show("Ingreso al sistema correcto", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicio_sesion_panel.Visible = false;

                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña son es incorrecto", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
  
    }
    private void tb_usuario_Enter(object sender, EventArgs e)
    {
        tb_usuario.Text = "";
    }
    private void tb_contra_Enter(object sender, EventArgs e)
    {
            tb_contra.UseSystemPasswordChar = true;
            tb_contra.Text = "";
    }
    private void tb_contra_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_contra.Text))
                {
                    tb_contra.Focus();
                    MessageBox.Show("No deje campos sin llenar", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    {
                        if ((tb_usuario.Text == "a2@gmail.com" && tb_contra.Text == "admin2") || (tb_usuario.Text == "a1@gmail.com" && tb_contra.Text == "admin1"))
                        {
                            btn_eliminar.Enabled = true;
                            btn_agregar.Enabled = true;
                            btn_modificar.Enabled = true;
                            MessageBox.Show("Ingreso al sistema correcto", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            inicio_sesion_panel.Visible = false;

                        }
                        else
                        {
                            MessageBox.Show("El usuario o la contraseña son es incorrecto", "Error ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        string correo;
        private void tb_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tb_usuario.TextLength < 1)
                {
                    MessageBox.Show("El campo no pude estar vacio", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    correo = tb_usuario.Text; // Obtener el valor del TextBox
                    bool terminaEnCorreoValido = correo.EndsWith("@gmail.com") ||
                                                 correo.EndsWith("@hotmail.com") ||
                                                 correo.EndsWith("@hotmail.es") ||
                                                 correo.EndsWith("@yahoo.com") ||
                                                 correo.EndsWith("@espoch.edu.ec") ||
                                                 correo.EndsWith("@outlook.com") ||
                                                correo.EndsWith("@outlook.es");
                    if (terminaEnCorreoValido)
                    {
                        tb_contra.Focus();
                    }
                    else
                    {
                        tb_usuario.Clear();
                        MessageBox.Show("El formato del correo electronico no es válido", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormEliminarProveedor());
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(panel_eliminar.Visible)
            {
                panel_eliminar.Visible = false;
            }
            else
            {
                panel_eliminar.Visible = true;
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormEliminarCateogira());
        }

        private void kryptonButton6_Click(object sender, EventArgs e)
        {
            OpenchildForm(new FormModificarProv());
            panel_modificar.Visible=false;
        }
    }
}
