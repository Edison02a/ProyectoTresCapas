namespace Cpresentacion1
{
    partial class FormReporteCategoriaPiezas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proveedorDataSet33 = new Cpresentacion1.ProveedorDataSet33();
            this.proveedorDataSet33BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDataSet34 = new Cpresentacion1.ProveedorDataSet34();
            this.vistaCantidadPiezasCategoria2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCantidadPiezasCategoria2TableAdapter = new Cpresentacion1.ProveedorDataSet34TableAdapters.VistaCantidadPiezasCategoria2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet33BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCantidadPiezasCategoria2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaCantidadPiezasCategoria2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cpresentacion1.ReportPiezasCategoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proveedorDataSet33
            // 
            this.proveedorDataSet33.DataSetName = "ProveedorDataSet33";
            this.proveedorDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorDataSet33BindingSource
            // 
            this.proveedorDataSet33BindingSource.DataSource = this.proveedorDataSet33;
            this.proveedorDataSet33BindingSource.Position = 0;
            // 
            // proveedorDataSet34
            // 
            this.proveedorDataSet34.DataSetName = "ProveedorDataSet34";
            this.proveedorDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCantidadPiezasCategoria2BindingSource
            // 
            this.vistaCantidadPiezasCategoria2BindingSource.DataMember = "VistaCantidadPiezasCategoria2";
            this.vistaCantidadPiezasCategoria2BindingSource.DataSource = this.proveedorDataSet34;
            // 
            // vistaCantidadPiezasCategoria2TableAdapter
            // 
            this.vistaCantidadPiezasCategoria2TableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteCategoriaPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteCategoriaPiezas";
            this.Text = "FormReporteCategoriaPiezas";
            this.Load += new System.EventHandler(this.FormReporteCategoriaPiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet33BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCantidadPiezasCategoria2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProveedorDataSet33 proveedorDataSet33;
        private System.Windows.Forms.BindingSource proveedorDataSet33BindingSource;
        private ProveedorDataSet34 proveedorDataSet34;
        private System.Windows.Forms.BindingSource vistaCantidadPiezasCategoria2BindingSource;
        private ProveedorDataSet34TableAdapters.VistaCantidadPiezasCategoria2TableAdapter vistaCantidadPiezasCategoria2TableAdapter;
    }
}