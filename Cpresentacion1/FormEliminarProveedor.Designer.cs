﻿namespace Cpresentacion1
{
    partial class FormEliminarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_ciudad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbx_povincia = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_direccion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_eliminar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_cedula = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tb_nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_cancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_apellido = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_buscar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_codbuscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.data_proveedor = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDataSet5 = new Cpresentacion1.ProveedorDataSet5();
            this.provBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDataSet3 = new Cpresentacion1.ProveedorDataSet3();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDataSet9 = new Cpresentacion1.ProveedorDataSet9();
            this.label11 = new System.Windows.Forms.Label();
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSet9TableAdapters.provTableAdapter();
            this.provTableAdapter1 = new Cpresentacion1.ProveedorDataSet3TableAdapters.provTableAdapter();
            this.provTableAdapter2 = new Cpresentacion1.ProveedorDataSet5TableAdapters.provTableAdapter();
            this.proveedorDataSet11 = new Cpresentacion1.ProveedorDataSet11();
            this.provBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter3 = new Cpresentacion1.ProveedorDataSet11TableAdapters.provTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroup1.Location = new System.Drawing.Point(12, 67);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonGroupBox1);
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonGroupBox2);
            this.kryptonGroup1.Panel.Controls.Add(this.data_proveedor);
            this.kryptonGroup1.Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonGroup1_Panel_Paint);
            this.kryptonGroup1.Size = new System.Drawing.Size(953, 417);
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonGroup1.TabIndex = 129;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(497, 18);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.label4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbx_ciudad);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label10);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cmbx_povincia);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tb_direccion);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_eliminar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tb_cedula);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tb_nombre);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btn_cancelar);
            this.kryptonGroupBox1.Panel.Controls.Add(this.tb_apellido);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(386, 367);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox1.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox1.TabIndex = 180;
            this.kryptonGroupBox1.Values.Heading = "Datos proveedor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 156;
            this.label4.Text = "Cédula: ";
            // 
            // cmbx_ciudad
            // 
            this.cmbx_ciudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbx_ciudad.Enabled = false;
            this.cmbx_ciudad.Location = new System.Drawing.Point(226, 198);
            this.cmbx_ciudad.Margin = new System.Windows.Forms.Padding(0);
            this.cmbx_ciudad.Name = "cmbx_ciudad";
            this.cmbx_ciudad.ReadOnly = true;
            this.cmbx_ciudad.Size = new System.Drawing.Size(92, 28);
            this.cmbx_ciudad.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cmbx_ciudad.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.cmbx_ciudad.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.cmbx_ciudad.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbx_ciudad.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cmbx_ciudad.StateCommon.Border.Rounding = 18;
            this.cmbx_ciudad.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.cmbx_ciudad.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_ciudad.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbx_ciudad.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbx_ciudad.TabIndex = 179;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 137;
            this.label10.Text = "Nombre: ";
            // 
            // cmbx_povincia
            // 
            this.cmbx_povincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cmbx_povincia.Enabled = false;
            this.cmbx_povincia.Location = new System.Drawing.Point(111, 198);
            this.cmbx_povincia.Margin = new System.Windows.Forms.Padding(0);
            this.cmbx_povincia.Name = "cmbx_povincia";
            this.cmbx_povincia.ReadOnly = true;
            this.cmbx_povincia.Size = new System.Drawing.Size(92, 28);
            this.cmbx_povincia.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.cmbx_povincia.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.cmbx_povincia.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.cmbx_povincia.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cmbx_povincia.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.cmbx_povincia.StateCommon.Border.Rounding = 18;
            this.cmbx_povincia.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.cmbx_povincia.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbx_povincia.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.cmbx_povincia.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbx_povincia.TabIndex = 178;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 139;
            this.label5.Text = "Dirección:";
            // 
            // tb_direccion
            // 
            this.tb_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_direccion.Enabled = false;
            this.tb_direccion.Location = new System.Drawing.Point(111, 146);
            this.tb_direccion.Margin = new System.Windows.Forms.Padding(0);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.ReadOnly = true;
            this.tb_direccion.Size = new System.Drawing.Size(207, 28);
            this.tb_direccion.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_direccion.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_direccion.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_direccion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_direccion.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_direccion.StateCommon.Border.Rounding = 18;
            this.tb_direccion.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_direccion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_direccion.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_direccion.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_direccion.TabIndex = 142;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(99, 287);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 31);
            this.btn_eliminar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_eliminar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_eliminar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.StateCommon.Border.Rounding = 8;
            this.btn_eliminar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.TabIndex = 136;
            this.btn_eliminar.Values.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // tb_cedula
            // 
            this.tb_cedula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_cedula.Enabled = false;
            this.tb_cedula.Location = new System.Drawing.Point(111, 23);
            this.tb_cedula.Margin = new System.Windows.Forms.Padding(0);
            this.tb_cedula.Name = "tb_cedula";
            this.tb_cedula.ReadOnly = true;
            this.tb_cedula.Size = new System.Drawing.Size(207, 28);
            this.tb_cedula.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_cedula.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_cedula.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_cedula.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_cedula.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_cedula.StateCommon.Border.Rounding = 18;
            this.tb_cedula.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_cedula.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cedula.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_cedula.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_cedula.TabIndex = 157;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_nombre.Enabled = false;
            this.tb_nombre.Location = new System.Drawing.Point(111, 64);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.ReadOnly = true;
            this.tb_nombre.Size = new System.Drawing.Size(207, 28);
            this.tb_nombre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_nombre.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_nombre.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_nombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_nombre.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_nombre.StateCommon.Border.Rounding = 18;
            this.tb_nombre.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_nombre.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_nombre.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_nombre.TabIndex = 148;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancelar.Location = new System.Drawing.Point(242, 287);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(93, 31);
            this.btn_cancelar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancelar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cancelar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_cancelar.StateCommon.Border.Rounding = 8;
            this.btn_cancelar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.TabIndex = 149;
            this.btn_cancelar.Values.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // tb_apellido
            // 
            this.tb_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_apellido.Enabled = false;
            this.tb_apellido.Location = new System.Drawing.Point(111, 104);
            this.tb_apellido.Margin = new System.Windows.Forms.Padding(0);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.ReadOnly = true;
            this.tb_apellido.Size = new System.Drawing.Size(207, 28);
            this.tb_apellido.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_apellido.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_apellido.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_apellido.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_apellido.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_apellido.StateCommon.Border.Rounding = 18;
            this.tb_apellido.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_apellido.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apellido.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_apellido.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_apellido.TabIndex = 155;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 152;
            this.label2.Text = "Provincia*";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 154;
            this.label3.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 153;
            this.label1.Text = "Ciudad*";
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(98, 209);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_buscar);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txt_codbuscar);
            this.kryptonGroupBox2.Panel.Controls.Add(this.label17);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(332, 167);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonGroupBox2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroupBox2.StateCommon.Border.Rounding = 10;
            this.kryptonGroupBox2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonGroupBox2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonGroupBox2.TabIndex = 177;
            this.kryptonGroupBox2.Values.Heading = "Búsqueda\r\n";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar.Location = new System.Drawing.Point(121, 86);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(93, 31);
            this.btn_buscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_buscar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_buscar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_buscar.StateCommon.Border.Rounding = 8;
            this.btn_buscar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.TabIndex = 107;
            this.btn_buscar.Values.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_codbuscar
            // 
            this.txt_codbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_codbuscar.Location = new System.Drawing.Point(138, 16);
            this.txt_codbuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_codbuscar.Name = "txt_codbuscar";
            this.txt_codbuscar.Size = new System.Drawing.Size(165, 28);
            this.txt_codbuscar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_codbuscar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_codbuscar.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txt_codbuscar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_codbuscar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_codbuscar.StateCommon.Border.Rounding = 18;
            this.txt_codbuscar.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txt_codbuscar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codbuscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_codbuscar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_codbuscar.TabIndex = 124;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 15);
            this.label17.TabIndex = 118;
            this.label17.Text = "Cédula proveedor:";
            // 
            // data_proveedor
            // 
            this.data_proveedor.AutoGenerateColumns = false;
            this.data_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciDataGridViewTextBoxColumn,
            this.nombrePDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.data_proveedor.DataSource = this.provBindingSource3;
            this.data_proveedor.Location = new System.Drawing.Point(84, 26);
            this.data_proveedor.Name = "data_proveedor";
            this.data_proveedor.ReadOnly = true;
            this.data_proveedor.Size = new System.Drawing.Size(444, 150);
            this.data_proveedor.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.data_proveedor.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.data_proveedor.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.data_proveedor.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Black;
            this.data_proveedor.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.data_proveedor.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.data_proveedor.TabIndex = 158;
            // 
            // ciDataGridViewTextBoxColumn
            // 
            this.ciDataGridViewTextBoxColumn.DataPropertyName = "ci";
            this.ciDataGridViewTextBoxColumn.HeaderText = "ci";
            this.ciDataGridViewTextBoxColumn.Name = "ciDataGridViewTextBoxColumn";
            this.ciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePDataGridViewTextBoxColumn
            // 
            this.nombrePDataGridViewTextBoxColumn.DataPropertyName = "nombreP";
            this.nombrePDataGridViewTextBoxColumn.HeaderText = "nombreP";
            this.nombrePDataGridViewTextBoxColumn.Name = "nombrePDataGridViewTextBoxColumn";
            this.nombrePDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // provBindingSource2
            // 
            this.provBindingSource2.DataMember = "prov";
            this.provBindingSource2.DataSource = this.proveedorDataSet5;
            // 
            // proveedorDataSet5
            // 
            this.proveedorDataSet5.DataSetName = "ProveedorDataSet5";
            this.proveedorDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource1
            // 
            this.provBindingSource1.DataMember = "prov";
            this.provBindingSource1.DataSource = this.proveedorDataSet3;
            // 
            // proveedorDataSet3
            // 
            this.proveedorDataSet3.DataSetName = "ProveedorDataSet3";
            this.proveedorDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.proveedorDataSet9;
            // 
            // proveedorDataSet9
            // 
            this.proveedorDataSet9.DataSetName = "ProveedorDataSet9";
            this.proveedorDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(452, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 128;
            this.label11.Text = "Eliminar provedor";
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
            // 
            // provTableAdapter1
            // 
            this.provTableAdapter1.ClearBeforeFill = true;
            // 
            // provTableAdapter2
            // 
            this.provTableAdapter2.ClearBeforeFill = true;
            // 
            // proveedorDataSet11
            // 
            this.proveedorDataSet11.DataSetName = "ProveedorDataSet11";
            this.proveedorDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource3
            // 
            this.provBindingSource3.DataMember = "prov";
            this.provBindingSource3.DataSource = this.proveedorDataSet11;
            // 
            // provTableAdapter3
            // 
            this.provTableAdapter3.ClearBeforeFill = true;
            // 
            // FormEliminarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 513);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.label11);
            this.Name = "FormEliminarProveedor";
            this.Text = "FormEliminarProveedor";
            this.Load += new System.EventHandler(this.FormEliminarProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView data_proveedor;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_cedula;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nombre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_eliminar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_direccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ProveedorDataSet9 proveedorDataSet9;
        private System.Windows.Forms.BindingSource provBindingSource;
        private ProveedorDataSet9TableAdapters.provTableAdapter provTableAdapter;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_buscar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_codbuscar;
        private System.Windows.Forms.Label label17;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cmbx_povincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox cmbx_ciudad;
        private ProveedorDataSet3 proveedorDataSet3;
        private System.Windows.Forms.BindingSource provBindingSource1;
        private ProveedorDataSet3TableAdapters.provTableAdapter provTableAdapter1;
        private ProveedorDataSet5 proveedorDataSet5;
        private System.Windows.Forms.BindingSource provBindingSource2;
        private ProveedorDataSet5TableAdapters.provTableAdapter provTableAdapter2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ProveedorDataSet11 proveedorDataSet11;
        private System.Windows.Forms.BindingSource provBindingSource3;
        private ProveedorDataSet11TableAdapters.provTableAdapter provTableAdapter3;
    }
}