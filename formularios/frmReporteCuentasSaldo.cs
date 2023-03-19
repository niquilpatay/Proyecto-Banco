using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banco.formularios
{
    public partial class frmReporteCuentasSaldo : Form
    {
        private static frmReporteCuentasSaldo instancia;

        public static frmReporteCuentasSaldo obtenerInstancia()
        {
            if (instancia == null)
                instancia = new frmReporteCuentasSaldo();
            return instancia;
        }
        public frmReporteCuentasSaldo()
        {
            InitializeComponent();
        }

        private void frmReporteCuentasSaldo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetCuentasSaldo.DT_CUENTAS_SALDO' Puede moverla o quitarla según sea necesario.
            this.dT_CUENTAS_SALDO_TableAdapter.Fill(this.dataSetCuentasSaldo.DT_CUENTAS_SALDO);

            this.reportViewer1.RefreshReport();
        }
    }
}
