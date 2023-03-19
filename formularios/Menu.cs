using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banco.formularios;

namespace banco
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void nuevoClienteCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNvoClienteCuenta form1 = new frmNvoClienteCuenta();
            form1.ShowDialog();
        }

        private void clientesYSaldoTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientesSaldo form2 = frmReporteClientesSaldo.obtenerInstancia();
            form2.ShowDialog();
        }

        private void clientesYSusMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteClientesMov form3 = frmReporteClientesMov.obtenerInstancia();
            form3.ShowDialog();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCuentasSaldo form4 = frmReporteCuentasSaldo.obtenerInstancia();
            form4.ShowDialog();
        }
    }
}
