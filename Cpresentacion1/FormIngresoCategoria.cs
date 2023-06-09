﻿using CEntidades;
using CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpresentacion1
{
    public partial class FormIngresoCategoria : Form
    {
        public FormIngresoCategoria()
        {
            InitializeComponent();
        }
        string nombre;
        float precio;
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
                    tb_precio.Focus();
                }

            }
        }

        private void tb_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    precio = float.Parse(tb_precio.Text);
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

        private void FormIngresoCategoria_Load(object sender, EventArgs e)
        {
            tb_nombre.Focus();
        }


        private void boton_Activarlo()
        {
            if(tb_nombre.TextLength>0 && tb_precio.TextLength>0)
            {
                btn_sig.Enabled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormIngresoCategoria_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void FormIngresoCategoria_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void kryptonGroup1_MouseMove(object sender, MouseEventArgs e)
        {
            boton_Activarlo();
        }

        private void btn_sig_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo culture = new CultureInfo("es-ES");
                EntidadesCategoria categoriadatos = new EntidadesCategoria();
                categoriadatos.CategCategoria = tb_nombre.Text;
                categoriadatos.PrecioCategoria = tb_precio.Text;
                COperaciones operaciones = new COperaciones();
                operaciones.IngresarCategoria(categoriadatos);
                MessageBox.Show("Los datos se guardaron correctamente", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNIQUE"))
                {
                    MessageBox.Show("Error: Ya existe una categoría con ese nombre", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Erro: " + ex.Message, "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
