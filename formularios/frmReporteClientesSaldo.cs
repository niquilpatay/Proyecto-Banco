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
    public partial class frmReporteClientesSaldo : Form
    {
        private static frmReporteClientesSaldo instancia;

        public static frmReporteClientesSaldo obtenerInstancia()
        {
            if (instancia == null)
                instancia = new frmReporteClientesSaldo();
            return instancia;
        }
        public frmReporteClientesSaldo()
        {
            InitializeComponent();
        }

        private void frmReporteClientesSaldo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientesSaldo.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dataSetClientesSaldo.clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
