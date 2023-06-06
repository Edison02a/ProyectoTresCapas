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
            this.data = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.proveedorDataSet = new Cpresentacion1.ProveedorDataSet();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.provTableAdapter();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.piezaTableAdapter();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelConten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
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
            this.btn_eliminar.Location = new System.Drawing.Point(344, 12);
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
            this.btn_modificar.Location = new System.Drawing.Point(218, 12);
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
            this.btn_agregar.Location = new System.Drawing.Point(116, 12);
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
            // 
            // data
            // 
            this.data.AutoGenerateColumns = false;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.ciudadDataGridViewTextBoxColumn,
            this.provinciaDataGridViewTextBoxColumn});
            this.data.DataSource = this.provBindingSource;
            this.data.Location = new System.Drawing.Point(48, 65);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(448, 150);
            this.data.TabIndex = 7;
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
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // ciudadDataGridViewTextBoxColumn
            // 
            this.ciudadDataGridViewTextBoxColumn.DataPropertyName = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.HeaderText = "ciudad";
            this.ciudadDataGridViewTextBoxColumn.Name = "ciudadDataGridViewTextBoxColumn";
            // 
            // provinciaDataGridViewTextBoxColumn
            // 
            this.provinciaDataGridViewTextBoxColumn.DataPropertyName = "provincia";
            this.provinciaDataGridViewTextBoxColumn.HeaderText = "provincia";
            this.provinciaDataGridViewTextBoxColumn.Name = "provinciaDataGridViewTextBoxColumn";
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoGenerateColumns = false;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn1,
            this.colorDataGridViewTextBoxColumn,
            this.centroDataGridViewTextBoxColumn,
            this.categDataGridViewTextBoxColumn});
            this.kryptonDataGridView1.DataSource = this.piezaBindingSource;
            this.kryptonDataGridView1.Location = new System.Drawing.Point(48, 243);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(450, 150);
            this.kryptonDataGridView1.TabIndex = 8;
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
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // centroDataGridViewTextBoxColumn
            // 
            this.centroDataGridViewTextBoxColumn.DataPropertyName = "centro";
            this.centroDataGridViewTextBoxColumn.HeaderText = "centro";
            this.centroDataGridViewTextBoxColumn.Name = "centroDataGridViewTextBoxColumn";
            // 
            // categDataGridViewTextBoxColumn
            // 
            this.categDataGridViewTextBoxColumn.DataPropertyName = "categ";
            this.categDataGridViewTextBoxColumn.HeaderText = "categ";
            this.categDataGridViewTextBoxColumn.Name = "categDataGridViewTextBoxColumn";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(531, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(531, 260);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.data);
            this.Controls.Add(this.panelConten);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelConten.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Panel panelConten;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_eliminar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_modificar;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_agregar;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView data;
        private ProveedorDataSet proveedorDataSet;
        private System.Windows.Forms.BindingSource provBindingSource;
        private ProveedorDataSetTableAdapters.provTableAdapter provTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinciaDataGridViewTextBoxColumn;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private ProveedorDataSetTableAdapters.piezaTableAdapter piezaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn centroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

