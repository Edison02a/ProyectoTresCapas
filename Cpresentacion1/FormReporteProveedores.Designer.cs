namespace Cpresentacion1
{
    partial class FormReporteProveedores
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
            this.proveedorDataSet28 = new Cpresentacion1.ProveedorDataSet28();
            this.provBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provTableAdapter = new Cpresentacion1.ProveedorDataSet28TableAdapters.provTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.provBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cpresentacion1.ReportProveedor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proveedorDataSet28
            // 
            this.proveedorDataSet28.DataSetName = "ProveedorDataSet28";
            this.proveedorDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // provBindingSource
            // 
            this.provBindingSource.DataMember = "prov";
            this.provBindingSource.DataSource = this.proveedorDataSet28;
            // 
            // provTableAdapter
            // 
            this.provTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteProveedores";
            this.Text = "FormReporteProveedores";
            this.Load += new System.EventHandler(this.FormReporteProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProveedorDataSet28 proveedorDataSet28;
        private System.Windows.Forms.BindingSource provBindingSource;
        private ProveedorDataSet28TableAdapters.provTableAdapter provTableAdapter;
    }
}