﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CEntidades;
using CLogica;
namespace Cpresentacion1
{
    public partial class FormIngresoPiezas : Form
    {
        string nombre,color,centro;
        COperaciones objOpera = new COperaciones();
        public FormIngresoPiezas()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nombre = tb_nombre.Text;


                if (string.IsNullOrEmpty(tb_nombre.Text))
                {
                    MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nombre.Focus();
                }
                else
                {
                    tb_color.Focus();
                }

            }
        }


        private void FormIngresoPiezas_Load(object sender, EventArgs e)
        {
            List<Entidades> DatosProveedor = objOpera.Lista();
            foreach (Entidades item in DatosProveedor)
            {
                cb_proveedor.Items.Add(item.NombreProv + " " + item.ApellidoProv + " " + item.CedulaProv);
            }


            List<EntidadesCategoria> datosCategoria = objOpera.Lista4();
            foreach (EntidadesCategoria item in datosCategoria)
            {
                cb_categoria.Items.Add(item.CategCategoria);
            }
        }

        private void tb_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               
                try
                {
                    int cantidad = int.Parse(tb_cantidad.Text);
                    if (int.Parse(tb_cantidad.Text) < 1)
                    {
                        MessageBox.Show("La cantidad no puede ser negativa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }   
                }
                catch
                {

                    if (string.IsNullOrEmpty(tb_cantidad.Text))
                    {
                        MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_cantidad.Focus();
                    }
                    else
                    {
                            MessageBox.Show("Ingrese número enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_cantidad.Clear();
                            tb_cantidad.Focus();
                        
                    }   
                }
            }
        }
        int id_pieza,id_proveedor;
        private void btn_sig_Click(object sender, EventArgs e)
        {
            List<EntidadesPieza> DatosPiezas = objOpera.Lista2();

            foreach (EntidadesPieza item in DatosPiezas)
            {
                if (item.IdPieza > id_pieza)
                {
                    id_pieza = item.IdPieza;
                }


            }
            id_pieza += 1;

            List<Entidades> Proveedor = objOpera.Lista();
            foreach (Entidades item in Proveedor)
            {
                if (item.NombreProv + " " + item.ApellidoProv + " " + item.CedulaProv == cb_proveedor.SelectedItem.ToString())
                {
                    id_proveedor = item.CedulaProv;
                }

            }

            try
            {
                EntidadesPieza piezaDatos = new EntidadesPieza();
                piezaDatos.NombrePieza = tb_nombre.Text;
                piezaDatos.ColorPieza = tb_color.Text;
                piezaDatos.CentroPieza = tb_centro.Text;
                piezaDatos.CategoriaPieza = cb_categoria.SelectedItem.ToString();
                COperaciones operaciones = new COperaciones();
                operaciones.IngresarPieza(piezaDatos);

                EntidadesSuministra suministraDatos = new EntidadesSuministra();
                suministraDatos.CantidadSuministra = Convert.ToInt32(tb_cantidad.Text);
                suministraDatos.IdPieza = id_pieza;
                suministraDatos.IdProveedor = id_proveedor;
                COperaciones operaciones2 = new COperaciones();
                operaciones2.IngresarPiezaIngresarSuministrar(suministraDatos);
                MessageBox.Show("Los datos se guardaron correctamente", "Estado del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cb_categoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_centro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                centro = tb_color.Text;


                if (string.IsNullOrEmpty(tb_color.Text))
                {
                    MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_centro.Focus();
                }
                else
                {
                    if (Regex.IsMatch(tb_color.Text, "^[a-zA-Z\\s]+$"))
                    {
                      
                    }
                    else
                    {

                        MessageBox.Show("El color no puede contener caracteres especiales", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_color.Clear();
                        tb_color.Focus();
                    }
                }

            }
        }

        private void tb_color_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                color = tb_color.Text;


                if (string.IsNullOrEmpty(tb_color.Text))
                {
                    MessageBox.Show("No se puede dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_color.Focus();
                }
                else
                {
                    if (Regex.IsMatch(tb_color.Text, "^[a-zA-Z\\s]+$"))
                    {
                        tb_centro.Focus();
                    }
                    else
                    {

                        MessageBox.Show("El color no puede contener caracteres especiales", "Infomación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_color.Clear();
                        tb_color.Focus();
                    }
                }

            }
        }
    }
}
