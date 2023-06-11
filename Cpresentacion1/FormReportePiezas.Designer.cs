namespace Cpresentacion1
{
    partial class FormReportePiezas
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
            this.proveedorDataSet14 = new Cpresentacion1.ProveedorDataSet14();
            this.piezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.piezaTableAdapter = new Cpresentacion1.ProveedorDataSet14TableAdapters.piezaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.piezaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Cpresentacion1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // proveedorDataSet14
            // 
            this.proveedorDataSet14.DataSetName = "ProveedorDataSet14";
            this.proveedorDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // piezaBindingSource
            // 
            this.piezaBindingSource.DataMember = "pieza";
            this.piezaBindingSource.DataSource = this.proveedorDataSet14;
            // 
            // piezaTableAdapter
            // 
            this.piezaTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportePiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportePiezas";
            this.Text = "FormReportePiezas";
            this.Load += new System.EventHandler(this.FormReportePiezas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piezaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ProveedorDataSet14 proveedorDataSet14;
        private System.Windows.Forms.BindingSource piezaBindingSource;
        private ProveedorDataSet14TableAdapters.piezaTableAdapter piezaTableAdapter;
    }
}