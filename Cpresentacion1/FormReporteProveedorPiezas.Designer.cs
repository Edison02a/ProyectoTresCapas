namespace Cpresentacion1
{
    partial class FormReporteProveedorPiezas
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
            this.proveedorDataSet32 = new Cpresentacion1.ProveedorDataSet32();
            this.vistaCantidadPiezasProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaCantidadPiezasProveedorTableAdapter = new Cpresentacion1.ProveedorDataSet32TableAdapters.VistaCantidadPiezasProveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCantidadPiezasProveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaCantidadPiezasProveedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cpresentacion1.ReportPrueba.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proveedorDataSet32
            // 
            this.proveedorDataSet32.DataSetName = "ProveedorDataSet32";
            this.proveedorDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaCantidadPiezasProveedorBindingSource
            // 
            this.vistaCantidadPiezasProveedorBindingSource.DataMember = "VistaCantidadPiezasProveedor";
            this.vistaCantidadPiezasProveedorBindingSource.DataSource = this.proveedorDataSet32;
            // 
            // vistaCantidadPiezasProveedorTableAdapter
            // 
            this.vistaCantidadPiezasProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteProveedorPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteProveedorPiezas";
            this.Text = "FormReporteProveedorPiezas";
            this.Load += new System.EventHandler(this.FormReporteProveedorPiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaCantidadPiezasProveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProveedorDataSet32 proveedorDataSet32;
        private System.Windows.Forms.BindingSource vistaCantidadPiezasProveedorBindingSource;
        private ProveedorDataSet32TableAdapters.VistaCantidadPiezasProveedorTableAdapter vistaCantidadPiezasProveedorTableAdapter;
    }
}