namespace banco.formularios
{
    partial class frmReporteCuentasSaldo
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
            this.dataSetCuentasSaldo = new banco.DataSetCuentasSaldo();
            this.dTCUENTASSALDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dT_CUENTAS_SALDO_TableAdapter = new banco.DataSetCuentasSaldoTableAdapters.DT_CUENTAS_SALDO_TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCUENTASSALDOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCuentasSaldo_Tabla";
            reportDataSource1.Value = this.dTCUENTASSALDOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "banco.reportes.rptCuentasSaldo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(901, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetCuentasSaldo
            // 
            this.dataSetCuentasSaldo.DataSetName = "DataSetCuentasSaldo";
            this.dataSetCuentasSaldo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTCUENTASSALDOBindingSource
            // 
            this.dTCUENTASSALDOBindingSource.DataMember = "DT_CUENTAS_SALDO";
            this.dTCUENTASSALDOBindingSource.DataSource = this.dataSetCuentasSaldo;
            // 
            // dT_CUENTAS_SALDO_TableAdapter
            // 
            this.dT_CUENTAS_SALDO_TableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteCuentasSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteCuentasSaldo";
            this.Text = "frmReporteCuentasSaldo";
            this.Load += new System.EventHandler(this.frmReporteCuentasSaldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTCUENTASSALDOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSetCuentasSaldo dataSetCuentasSaldo;
        private System.Windows.Forms.BindingSource dTCUENTASSALDOBindingSource;
        private DataSetCuentasSaldoTableAdapters.DT_CUENTAS_SALDO_TableAdapter dT_CUENTAS_SALDO_TableAdapter;
    }
}