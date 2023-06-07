namespace Cpresentacion1
{
    partial class FormIngresoCategoria
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
            this.btn_cancelar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_sig = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tb_precio = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).BeginInit();
            this.kryptonGroup1.Panel.SuspendLayout();
            this.kryptonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonGroup1
            // 
            this.kryptonGroup1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kryptonGroup1.Location = new System.Drawing.Point(90, 50);
            this.kryptonGroup1.Name = "kryptonGroup1";
            // 
            // kryptonGroup1.Panel
            // 
            this.kryptonGroup1.Panel.Controls.Add(this.btn_cancelar);
            this.kryptonGroup1.Panel.Controls.Add(this.tb_nombre);
            this.kryptonGroup1.Panel.Controls.Add(this.btn_sig);
            this.kryptonGroup1.Panel.Controls.Add(this.tb_precio);
            this.kryptonGroup1.Panel.Controls.Add(this.label5);
            this.kryptonGroup1.Panel.Controls.Add(this.label10);
            this.kryptonGroup1.Size = new System.Drawing.Size(638, 292);
            this.kryptonGroup1.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonGroup1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonGroup1.StateCommon.Border.Rounding = 10;
            this.kryptonGroup1.TabIndex = 131;
            this.kryptonGroup1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kryptonGroup1_MouseMove);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_cancelar.Location = new System.Drawing.Point(374, 191);
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
            this.tb_nombre.Location = new System.Drawing.Point(220, 34);
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
            this.tb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nombre_KeyPress);
            // 
            // btn_sig
            // 
            this.btn_sig.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sig.Location = new System.Drawing.Point(192, 191);
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
            this.btn_sig.Click += new System.EventHandler(this.btn_sig_Click);
            // 
            // tb_precio
            // 
            this.tb_precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tb_precio.Location = new System.Drawing.Point(220, 91);
            this.tb_precio.Margin = new System.Windows.Forms.Padding(0);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(207, 28);
            this.tb_precio.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tb_precio.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.tb_precio.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.tb_precio.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tb_precio.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.tb_precio.StateCommon.Border.Rounding = 18;
            this.tb_precio.StateCommon.Content.Color1 = System.Drawing.Color.DimGray;
            this.tb_precio.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precio.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tb_precio.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tb_precio.TabIndex = 142;
            this.tb_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precio_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(137, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 139;
            this.label5.Text = "Precio:\r\n";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(134, 42);
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
            this.label11.Location = new System.Drawing.Point(339, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 23);
            this.label11.TabIndex = 130;
            this.label11.Text = "Agregar categoría";
            // 
            // FormIngresoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kryptonGroup1);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIngresoCategoria";
            this.Text = "FormIngresoCategoria";
            this.Load += new System.EventHandler(this.FormIngresoCategoria_Load);
            this.MouseHover += new System.EventHandler(this.FormIngresoCategoria_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormIngresoCategoria_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1.Panel)).EndInit();
            this.kryptonGroup1.Panel.ResumeLayout(false);
            this.kryptonGroup1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroup1)).EndInit();
            this.kryptonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonGroup kryptonGroup1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_cancelar;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_nombre;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_sig;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tb_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}