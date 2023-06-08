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
            this.panel_agregar = new System.Windows.Forms.Panel();
            this.kryptonButton3 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.proveedorDataSet = new Cpresentacion1.ProveedorDataSet();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.provTableAdapter();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.piezaTableAdapter();
            this.suministraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suministraTableAdapter = new Cpresentacion1.ProveedorDataSetTableAdapters.suministraTableAdapter();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.ComboBox2 = new System.Windows.Forms.ComboBox();
            this.ComboBox3 = new System.Windows.Forms.ComboBox();
            this.ComboBox4 = new System.Windows.Forms.ComboBox();
            this.panel_conten = new System.Windows.Forms.Panel();
            this.panelConten.SuspendLayout();
            this.panel_agregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).BeginInit();
            this.panel_conten.SuspendLayout();
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
            this.panelConten.Controls.Add(this.panel_agregar);
            this.panelConten.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConten.Location = new System.Drawing.Point(0, 0);
            this.panelConten.Name = "panelConten";
            this.panelConten.Size = new System.Drawing.Size(800, 82);
            this.panelConten.TabIndex = 6;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Location = new System.Drawing.Point(238, 7);
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
            this.btn_modificar.Location = new System.Drawing.Point(116, 7);
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
            this.btn_agregar.Location = new System.Drawing.Point(14, 7);
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
            // panel_agregar
            // 
            this.panel_agregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_agregar.Controls.Add(this.kryptonButton3);
            this.panel_agregar.Controls.Add(this.kryptonButton2);
            this.panel_agregar.Controls.Add(this.kryptonButton1);
            this.panel_agregar.Location = new System.Drawing.Point(14, 43);
            this.panel_agregar.Name = "panel_agregar";
            this.panel_agregar.Size = new System.Drawing.Size(277, 36);
            this.panel_agregar.TabIndex = 18;
            // 
            // kryptonButton3
            // 
            this.kryptonButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton3.Location = new System.Drawing.Point(182, 3);
            this.kryptonButton3.Name = "kryptonButton3";
            this.kryptonButton3.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.Size = new System.Drawing.Size(85, 30);
            this.kryptonButton3.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryptonButton3.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateCommon.Border.Rounding = 5;
            this.kryptonButton3.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.kryptonButton3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton3.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton3.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton3.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton3.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton3.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton3.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton3.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton3.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton3.TabIndex = 21;
            this.kryptonButton3.Values.Text = "Categoria\r\n";
            this.kryptonButton3.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton2.Location = new System.Drawing.Point(101, 3);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.Size = new System.Drawing.Size(75, 30);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 5;
            this.kryptonButton2.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.TabIndex = 20;
            this.kryptonButton2.Values.Text = "Pieza";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kryptonButton1.Location = new System.Drawing.Point(3, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.Size = new System.Drawing.Size(92, 30);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 5;
            this.kryptonButton1.StateCommon.Content.LongText.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(-1, -1, -1, -2);
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateDisabled.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateDisabled.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateNormal.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.Silver;
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.Silver;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.TabIndex = 19;
            this.kryptonButton1.Values.Text = "Proveedor\r\n";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
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
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(161, 117);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 19;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // ComboBox2
            // 
            this.ComboBox2.FormattingEnabled = true;
            this.ComboBox2.Location = new System.Drawing.Point(367, 13);
            this.ComboBox2.Name = "ComboBox2";
            this.ComboBox2.Size = new System.Drawing.Size(121, 21);
            this.ComboBox2.TabIndex = 20;
            // 
            // ComboBox3
            // 
            this.ComboBox3.FormattingEnabled = true;
            this.ComboBox3.Location = new System.Drawing.Point(510, 13);
            this.ComboBox3.Name = "ComboBox3";
            this.ComboBox3.Size = new System.Drawing.Size(121, 21);
            this.ComboBox3.TabIndex = 21;
            // 
            // ComboBox4
            // 
            this.ComboBox4.FormattingEnabled = true;
            this.ComboBox4.Location = new System.Drawing.Point(652, 13);
            this.ComboBox4.Name = "ComboBox4";
            this.ComboBox4.Size = new System.Drawing.Size(121, 21);
            this.ComboBox4.TabIndex = 22;
            // 
            // panel_conten
            // 
            this.panel_conten.Controls.Add(this.ComboBox4);
            this.panel_conten.Controls.Add(this.ComboBox3);
            this.panel_conten.Controls.Add(this.ComboBox2);
            this.panel_conten.Controls.Add(this.ComboBox1);
            this.panel_conten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_conten.Location = new System.Drawing.Point(0, 82);
            this.panel_conten.Name = "panel_conten";
            this.panel_conten.Size = new System.Drawing.Size(800, 368);
            this.panel_conten.TabIndex = 19;
            this.panel_conten.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_conten_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_conten);
            this.Controls.Add(this.panelConten);
            this.Name = "Form1";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelConten.ResumeLayout(false);
            this.panel_agregar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suministraBindingSource)).EndInit();
            this.panel_conten.ResumeLayout(false);
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
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.ComboBox ComboBox2;
        private System.Windows.Forms.ComboBox ComboBox3;
        private System.Windows.Forms.ComboBox ComboBox4;
        private System.Windows.Forms.Panel panel_conten;
    }
}

