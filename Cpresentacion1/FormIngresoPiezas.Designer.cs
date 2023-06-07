namespace Cpresentacion1
{
    partial class FormIngresoPiezas
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
            this.kryptonGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonGroup();
            this.cb_categoria = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_cancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_sig = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_color = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_centro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_proveedor = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroup1.Location = new System.Drawing.Point(30, 45);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.kryptonTextBox1);
            this.kryptonGroup1.Panel.Controls.Add(this.label4);
            this.kryptonGroup1.Panel.Controls.Add(this.cb_proveedor);
            this.kryptonGroup1.Panel.Controls.Add(this.label3);
            this.kryptonGroup1.Panel.Controls.Add(this.label2);
            this.kryptonGroup1.Panel.Controls.Add(this.label1);
            this.kryptonGroup1.Panel.Controls.Add(this.tb_centro);
            this.kryptonGroup1.Panel.Controls.Add(this.cb_categoria);
            this.kryptonGroup1.Panel.Controls.Add(this.btn_cancelar);
            this.kryptonGroup1.Panel.Controls.Add(this.tb_nombre);
            this.kryptonGroup1.Panel.Controls.Add(this.btn_sig);
            this.kryptonGroup1.Panel.Controls.Add(this.tb_color);
            this.kryptonGroup1.Panel.Controls.Add(this.label5);
            this.kryptonGroup1.Panel.Controls.Add(this.label10);
            this.kryptonGroup1.Size = new System.Drawing.Size(744, 308);
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonGroup1.TabIndex = 129;
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_categoria.DropDownWidth = 88;
            this.cb_categoria.Items.AddRange(new object[] {
            "Azuay",
            "Bolívar",
            "Cañar",
            "Carchi",
            "Chimborazo",
            "Cotopaxi",
            "El Oro",
            "Esmeraldas",
            "Galápagos",
            "Guayas",
            "Imbabura",
            "Loja",
            "Los Ríos",
            "Manabí",
            "Morona Santiago",
            "Napo",
            "Orellana",
            "Pastaza",
            "Pichincha",
            "Santa Elena",
            "Santo Domingo de los Tsáchilas",
            "Sucumbíos",
            "Tungurahua",
            "Zamora Chinchipe"});
            this.cb_categoria.Location = new System.Drawing.Point(273, 162);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(92, 27);
            this.cb_categoria.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cb_categoria.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cb_categoria.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_categoria.StateCommon.ComboBox.Border.Rounding = 10;
            this.cb_categoria.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.TabIndex = 151;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancelar.Location = new System.Drawing.Point(415, 250);
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
            // tb_nombre
            // 
            this.tb_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_nombre.Location = new System.Drawing.Point(273, 34);
            this.tb_nombre.Margin = new System.Windows.Forms.Padding(0);
            this.tb_nombre.Name = "tb_nombre";
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
            // btn_sig
            // 
            this.btn_sig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sig.Enabled = false;
            this.btn_sig.Location = new System.Drawing.Point(272, 250);
            this.btn_sig.Name = "btn_sig";
            this.btn_sig.Size = new System.Drawing.Size(93, 31);
            this.btn_sig.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sig.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sig.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_sig.StateCommon.Border.Rounding = 8;
            this.btn_sig.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sig.TabIndex = 136;
            this.btn_sig.Values.Text = "Guardar";
            // 
            // tb_color
            // 
            this.tb_color.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_color.Location = new System.Drawing.Point(273, 74);
            this.tb_color.Margin = new System.Windows.Forms.Padding(0);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(207, 28);
            this.tb_color.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_color.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_color.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_color.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_color.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_color.StateCommon.Border.Rounding = 18;
            this.tb_color.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_color.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_color.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_color.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_color.TabIndex = 142;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 139;
            this.label5.Text = "Color:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(187, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 137;
            this.label10.Text = "Nombre: ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(338, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 23);
            this.label11.TabIndex = 128;
            this.label11.Text = "Agregar piezas";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tb_centro
            // 
            this.tb_centro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_centro.Location = new System.Drawing.Point(273, 115);
            this.tb_centro.Margin = new System.Windows.Forms.Padding(0);
            this.tb_centro.Name = "tb_centro";
            this.tb_centro.Size = new System.Drawing.Size(207, 28);
            this.tb_centro.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_centro.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_centro.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_centro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_centro.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_centro.StateCommon.Border.Rounding = 18;
            this.tb_centro.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_centro.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_centro.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_centro.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_centro.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 153;
            this.label1.Text = "Centro:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 154;
            this.label2.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(384, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 155;
            this.label3.Text = "Proveedor:";
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cb_proveedor.DropDownWidth = 88;
            this.cb_proveedor.Items.AddRange(new object[] {
            "Azuay",
            "Bolívar",
            "Cañar",
            "Carchi",
            "Chimborazo",
            "Cotopaxi",
            "El Oro",
            "Esmeraldas",
            "Galápagos",
            "Guayas",
            "Imbabura",
            "Loja",
            "Los Ríos",
            "Manabí",
            "Morona Santiago",
            "Napo",
            "Orellana",
            "Pastaza",
            "Pichincha",
            "Santa Elena",
            "Santo Domingo de los Tsáchilas",
            "Sucumbíos",
            "Tungurahua",
            "Zamora Chinchipe"});
            this.cb_proveedor.Location = new System.Drawing.Point(458, 162);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(92, 27);
            this.cb_proveedor.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.cb_proveedor.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.cb_proveedor.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cb_proveedor.StateCommon.ComboBox.Border.Rounding = 10;
            this.cb_proveedor.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_proveedor.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 157;
            this.label4.Text = "Color:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.kryptonTextBox1.Location = new System.Drawing.Point(273, 202);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(207, 28);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonTextBox1.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonTextBox1.StateCommon.Border.Rounding = 18;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryptonTextBox1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonTextBox1.TabIndex = 158;
            // 
            // FormIngresoPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresoPiezas";
            this.Text = "FormIngresoPiezas";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cb_categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_categoria;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nombre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sig;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_color;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_centro;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cb_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private System.Windows.Forms.Label label4;
    }
}