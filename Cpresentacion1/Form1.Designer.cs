namespace Cpresentacion1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.panelConten = new System.Windows.Forms.Panel();
            this.btn_eliminar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_modificar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_agregar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.proveedorDataSet = new Cpresentacion1.ProveedorDataSet();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.provTableAdapter();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.piezaTableAdapter();
            this.suministraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suministraTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.suministraTableAdapter();
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_pieza = new System.Windows.Forms.Button();
            this.btn_proveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboBox4 = new System.Windows.Forms.ComboBox();
            this.panelConten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).BeginInit();
            this.panel_agregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.ArrowRight.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.ArrowRight.Image")));
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormClose.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMax.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMax.Image")));
            this.kryptonPalette1.ButtonSpecs.FormMin.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormMin.Image")));
            this.kryptonPalette1.ButtonSpecs.FormRestore.Image = ((System.Drawing.Image)(resources.GetObject("kryptonPalette1.ButtonSpecs.FormRestore.Image")));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // panelConten
            // 
            this.panelConten.Controls.Add(this.btn_eliminar);
            this.panelConten.Controls.Add(this.btn_modificar);
            this.panelConten.Controls.Add(this.btn_agregar);
            this.panelConten.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConten.Location = new System.Drawing.Point(0, 0);
            this.panelConten.Name = "panelConten";
            this.panelConten.Size = new System.Drawing.Size(800, 48);
            this.panelConten.TabIndex = 6;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Location = new System.Drawing.Point(367, 18);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_eliminar.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_eliminar.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btn_eliminar.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btn_eliminar.Size = new System.Drawing.Size(79, 30);
            this.btn_eliminar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_eliminar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_eliminar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.btn_eliminar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.StateCommon.Border.Rounding = 5;
            this.btn_eliminar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.btn_eliminar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btn_eliminar.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btn_eliminar.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btn_eliminar.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btn_eliminar.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_eliminar.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_eliminar.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_eliminar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_eliminar.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_eliminar.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_eliminar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Values.Text = "Eliminar";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.Location = new System.Drawing.Point(211, 18);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_modificar.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_modificar.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btn_modificar.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btn_modificar.Size = new System.Drawing.Size(99, 30);
            this.btn_modificar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_modificar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_modificar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.btn_modificar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modificar.StateCommon.Border.Rounding = 5;
            this.btn_modificar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.btn_modificar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btn_modificar.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btn_modificar.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modificar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btn_modificar.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btn_modificar.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modificar.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_modificar.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_modificar.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modificar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_modificar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_modificar.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_modificar.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_modificar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Values.Text = "Modificar";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.Location = new System.Drawing.Point(13, 18);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_agregar.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.btn_agregar.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btn_agregar.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.btn_agregar.Size = new System.Drawing.Size(75, 30);
            this.btn_agregar.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_agregar.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btn_agregar.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.btn_agregar.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_agregar.StateCommon.Border.Rounding = 5;
            this.btn_agregar.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.btn_agregar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btn_agregar.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.btn_agregar.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_agregar.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btn_agregar.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.btn_agregar.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_agregar.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_agregar.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_agregar.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_agregar.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.btn_agregar.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.btn_agregar.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btn_agregar.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btn_agregar.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Values.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // proveedorDataSet
            // 
            this.proveedorDataSet.DataSetName = "ProveedorDataSet";
            this.proveedorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.proveedorDataSet;
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
            // 
            // piezaBindingSource
            // 
            this.piezaBindingSource.DataMember = "pieza";
            this.piezaBindingSource.DataSource = this.proveedorDataSet;
            // 
            // piezaTableAdapter
            // 
            this.piezaTableAdapter.ClearBeforeFill = true;
            // 
            // suministraBindingSource
            // 
            this.suministraBindingSource.DataMember = "suministra";
            this.suministraBindingSource.DataSource = this.proveedorDataSet;
            // 
            // suministraTableAdapter
            // 
            this.suministraTableAdapter.ClearBeforeFill = true;
            // 
            // panel_agregar
            // 
            this.panel_agregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_agregar.Controls.Add(this.button7);
            this.panel_agregar.Controls.Add(this.btn_pieza);
            this.panel_agregar.Controls.Add(this.btn_proveedor);
            this.panel_agregar.Location = new System.Drawing.Point(13, 0);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(97, 104);
            this.panel_agregar.TabIndex = 18;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.Location = new System.Drawing.Point(0, 64);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(95, 31);
            this.button7.TabIndex = 4;
            this.button7.Text = "Categoria";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_pieza
            // 
            this.btn_pieza.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pieza.FlatAppearance.BorderSize = 0;
            this.btn_pieza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pieza.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pieza.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pieza.Location = new System.Drawing.Point(0, 33);
            this.btn_pieza.Name = "btn_pieza";
            this.btn_pieza.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pieza.Size = new System.Drawing.Size(95, 31);
            this.btn_pieza.TabIndex = 2;
            this.btn_pieza.Text = "Piezas";
            this.btn_pieza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pieza.UseVisualStyleBackColor = true;
            // 
            // btn_proveedor
            // 
            this.btn_proveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proveedor.FlatAppearance.BorderSize = 0;
            this.btn_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedor.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_proveedor.Location = new System.Drawing.Point(0, 0);
            this.btn_proveedor.Name = "btn_proveedor";
            this.btn_proveedor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_proveedor.Size = new System.Drawing.Size(95, 33);
            this.btn_proveedor.TabIndex = 0;
            this.btn_proveedor.Text = "Proveedor";
            this.btn_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComboBox4);
            this.panel1.Controls.Add(this.ComboBox3);
            this.panel1.Controls.Add(this.ComboBox2);
            this.panel1.Controls.Add(this.ComboBox1);
            this.panel1.Controls.Add(this.panel_agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 402);
            this.panel1.TabIndex = 19;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(151, 207);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 19;
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(340, 191);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 21);
            this.ComboBox2.TabIndex = 20;
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(536, 207);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(121, 21);
            this.ComboBox3.TabIndex = 21;
            // 
            // ComboBox4
            // 
            this.ComboBox4.FormattingEnabled = true;
            this.ComboBox4.Location = new System.Drawing.Point(483, 285);
            this.ComboBox4.Name = "ComboBox4";
            this.ComboBox4.Size = new System.Drawing.Size(121, 21);
            this.ComboBox4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelConten);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelConten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).EndInit();
            this.panel_agregar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panelConten;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_eliminar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_modificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_agregar;
        private ProveedorDataSet proveedorDataSet;
        private System.Windows.Forms.BindingSource provBindingSource;
        private ProveedorDataSetTableAdapters.provTableAdapter provTableAdapter;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private ProveedorDataSetTableAdapters.piezaTableAdapter piezaTableAdapter;
        private System.Windows.Forms.BindingSource suministraBindingSource;
        private ProveedorDataSetTableAdapters.suministraTableAdapter suministraTableAdapter;
        private System.Windows.Forms.Panel panel_agregar;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_pieza;
        private System.Windows.Forms.Button btn_proveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBox4;
        private System.Windows.Forms.ComboBox ComboBox3;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.ComboBox ComboBox1;
    }
}

