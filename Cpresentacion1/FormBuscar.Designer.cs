namespace Cpresentacion1
{
    partial class FormBuscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.CheckBox();
            this.cb_codigo = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.btn_buscar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_buscar = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_campo = new System.Windows.Forms.Label();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_nombre = new System.Windows.Forms.CheckBox();
            this.ci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.proveedorDataSet23 = new Cpresentacion1.ProveedorDataSet23();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSet23TableAdapters.provTableAdapter();
            this.ciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.proveedorDataSet24 = new Cpresentacion1.ProveedorDataSet24();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new Cpresentacion1.ProveedorDataSet24TableAdapters.piezaTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.proveedorDataSet25 = new Cpresentacion1.ProveedorDataSet25();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Cpresentacion1.ProveedorDataSet25TableAdapters.categoriaTableAdapter();
            this.categDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 148;
            this.label1.Text = "Resultado de la búsqueda";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_categoria.AutoSize = true;
            this.cb_categoria.Location = new System.Drawing.Point(657, 47);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(73, 17);
            this.cb_categoria.TabIndex = 146;
            this.cb_categoria.Text = "Categoría";
            this.cb_categoria.UseVisualStyleBackColor = true;
            this.cb_categoria.CheckedChanged += new System.EventHandler(this.cb_categoria_CheckedChanged);
            // 
            // cb_codigo
            // 
            this.cb_codigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_codigo.AutoSize = true;
            this.cb_codigo.Location = new System.Drawing.Point(454, 47);
            this.cb_codigo.Name = "cb_codigo";
            this.cb_codigo.Size = new System.Drawing.Size(111, 17);
            this.cb_codigo.TabIndex = 145;
            this.cb_codigo.Text = "Cédula Proveedor";
            this.cb_codigo.UseVisualStyleBackColor = true;
            this.cb_codigo.CheckedChanged += new System.EventHandler(this.cb_codigo_CheckedChanged);
            this.cb_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_codigo_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ci,
            this.nombre,
            this.apellido,
            this.direccion,
            this.provincia,
            this.ciudad});
            this.dataGridView1.Location = new System.Drawing.Point(20, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(375, 48);
            this.dataGridView1.TabIndex = 144;
            this.dataGridView1.Visible = false;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(454, 81);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.btn_buscar);
            this.kryptonGroupBox2.Panel.Controls.Add(this.txt_buscar);
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbl_campo);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(276, 167);
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
            this.kryptonGroupBox2.TabIndex = 143;
            this.kryptonGroupBox2.Values.Heading = "Búsqueda\r\n";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar.Enabled = false;
            this.btn_buscar.Location = new System.Drawing.Point(89, 76);
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
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_buscar.Enabled = false;
            this.txt_buscar.Location = new System.Drawing.Point(89, 22);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(132, 28);
            this.txt_buscar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_buscar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txt_buscar.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txt_buscar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_buscar.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_buscar.StateCommon.Border.Rounding = 18;
            this.txt_buscar.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.txt_buscar.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txt_buscar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_buscar.TabIndex = 124;
            // 
            // lbl_campo
            // 
            this.lbl_campo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_campo.AutoSize = true;
            this.lbl_campo.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campo.Location = new System.Drawing.Point(14, 35);
            this.lbl_campo.Name = "lbl_campo";
            this.lbl_campo.Size = new System.Drawing.Size(48, 15);
            this.lbl_campo.TabIndex = 118;
            this.lbl_campo.Text = "Campo:";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonButton1.Location = new System.Drawing.Point(546, 492);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(100, 31);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 8;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 142;
            this.kryptonButton1.Values.Text = "Atrás";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(519, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 23);
            this.label11.TabIndex = 141;
            this.label11.Text = "Buscar producto\r\n";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // cb_nombre
            // 
            this.cb_nombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_nombre.AutoSize = true;
            this.cb_nombre.Location = new System.Drawing.Point(583, 47);
            this.cb_nombre.Name = "cb_nombre";
            this.cb_nombre.Size = new System.Drawing.Size(57, 17);
            this.cb_nombre.TabIndex = 147;
            this.cb_nombre.Text = "Piezas";
            this.cb_nombre.UseVisualStyleBackColor = true;
            this.cb_nombre.CheckedChanged += new System.EventHandler(this.cb_nombre_CheckedChanged);
            // 
            // ci
            // 
            this.ci.HeaderText = "Cédula";
            this.ci.Name = "ci";
            this.ci.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // provincia
            // 
            this.provincia.HeaderText = "Provincia";
            this.provincia.Name = "provincia";
            this.provincia.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(20, 64);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(341, 51);
            this.dataGridView2.TabIndex = 149;
            this.dataGridView2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.dataGridView3);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(102, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 177);
            this.panel1.TabIndex = 150;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView3.Location = new System.Drawing.Point(456, 64);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(287, 51);
            this.dataGridView3.TabIndex = 150;
            this.dataGridView3.Visible = false;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ciDataGridViewTextBoxColumn,
            this.nombrePDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.provBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(101, 33);
            this.dataGridView4.TabIndex = 151;
            this.dataGridView4.Visible = false;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // proveedorDataSet23
            // 
            this.proveedorDataSet23.DataSetName = "ProveedorDataSet23";
            this.proveedorDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.proveedorDataSet23;
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.dataGridView6);
            this.panel2.Controls.Add(this.dataGridView5);
            this.panel2.Controls.Add(this.dataGridView4);
            this.panel2.Location = new System.Drawing.Point(63, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 148);
            this.panel2.TabIndex = 152;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.piezaBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(39, 42);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(50, 33);
            this.dataGridView5.TabIndex = 152;
            this.dataGridView5.Visible = false;
            // 
            // proveedorDataSet24
            // 
            this.proveedorDataSet24.DataSetName = "ProveedorDataSet24";
            this.proveedorDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piezaBindingSource
            // 
            this.piezaBindingSource.DataMember = "pieza";
            this.piezaBindingSource.DataSource = this.proveedorDataSet24;
            // 
            // piezaTableAdapter
            // 
            this.piezaTableAdapter.ClearBeforeFill = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.categoriaBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(154, 58);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(50, 33);
            this.dataGridView6.TabIndex = 153;
            this.dataGridView6.Visible = false;
            // 
            // proveedorDataSet25
            // 
            this.proveedorDataSet25.DataSetName = "ProveedorDataSet25";
            this.proveedorDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.proveedorDataSet25;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // categDataGridViewTextBoxColumn
            // 
            this.categDataGridViewTextBoxColumn.DataPropertyName = "categ";
            this.categDataGridViewTextBoxColumn.HeaderText = "categ";
            this.categDataGridViewTextBoxColumn.Name = "categDataGridViewTextBoxColumn";
            this.categDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Categoría";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cb_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.cb_codigo);
            this.Controls.Add(this.kryptonGroupBox2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            this.Load += new System.EventHandler(this.FormBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb_categoria;
        private System.Windows.Forms.CheckBox cb_codigo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_buscar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_buscar;
        private System.Windows.Forms.Label lbl_campo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cb_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ci;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private ProveedorDataSet23 proveedorDataSet23;
        private System.Windows.Forms.BindingSource provBindingSource;
        private ProveedorDataSet23TableAdapters.provTableAdapter provTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView5;
        private ProveedorDataSet24 proveedorDataSet24;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private ProveedorDataSet24TableAdapters.piezaTableAdapter piezaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView6;
        private ProveedorDataSet25 proveedorDataSet25;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private ProveedorDataSet25TableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}