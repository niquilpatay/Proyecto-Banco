namespace banco.formularios
{
    partial class frmReporteClientesMov
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
            this.dataSetClientesMovimientos = new banco.DataSetClientesMovimientos();
            this.clientesMovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesMovTableAdapter = new banco.DataSetClientesMovimientosTableAdapters.clientesMovTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientesMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetClientesMov";
            reportDataSource1.Value = this.clientesMovBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banco.reportes.rptClientesMovimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetClientesMovimientos
            // 
            this.dataSetClientesMovimientos.DataSetName = "DataSetClientesMovimientos";
            this.dataSetClientesMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesMovBindingSource
            // 
            this.clientesMovBindingSource.DataMember = "clientesMov";
            this.clientesMovBindingSource.DataSource = this.dataSetClientesMovimientos;
            // 
            // clientesMovTableAdapter
            // 
            this.clientesMovTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteClientesMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteClientesMov";
            this.Text = "frmReporteClientesMov";
            this.Load += new System.EventHandler(this.frmReporteClientesMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetClientesMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesMovBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetClientesMovimientos dataSetClientesMovimientos;
        private System.Windows.Forms.BindingSource clientesMovBindingSource;
        private DataSetClientesMovimientosTableAdapters.clientesMovTableAdapter clientesMovTableAdapter;
    }
}