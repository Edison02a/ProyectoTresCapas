namespace Cpresentacion1
{
    partial class FormReporteCategorias
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
            this.proveedorDataSet18 = new Cpresentacion1.ProveedorDataSet18();
            this.proveedorDataSet18BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDataSet29 = new Cpresentacion1.ProveedorDataSet29();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Cpresentacion1.ProveedorDataSet29TableAdapters.categoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet18BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.categoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cpresentacion1.ReporteCategorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proveedorDataSet18
            // 
            this.proveedorDataSet18.DataSetName = "ProveedorDataSet18";
            this.proveedorDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorDataSet18BindingSource
            // 
            this.proveedorDataSet18BindingSource.DataSource = this.proveedorDataSet18;
            this.proveedorDataSet18BindingSource.Position = 0;
            // 
            // proveedorDataSet29
            // 
            this.proveedorDataSet29.DataSetName = "ProveedorDataSet29";
            this.proveedorDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.proveedorDataSet29;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteCategorias";
            this.Text = "FormReporteCategorias";
            this.Load += new System.EventHandler(this.FormReporteCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet18BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProveedorDataSet18 proveedorDataSet18;
        private System.Windows.Forms.BindingSource proveedorDataSet18BindingSource;
        private ProveedorDataSet29 proveedorDataSet29;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private ProveedorDataSet29TableAdapters.categoriaTableAdapter categoriaTableAdapter;
    }
}