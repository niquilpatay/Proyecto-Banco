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
    public partial class frmReporteClientesMov : Form
    {
        private static frmReporteClientesMov instancia;

        public static frmReporteClientesMov obtenerInstancia()
        {
            if (instancia == null)
                instancia = new frmReporteClientesMov();
            return instancia;
        }
        public frmReporteClientesMov()
        {
            InitializeComponent();
        }

        private void frmReporteClientesMov_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetClientesMovimientos.clientesMov' Puede moverla o quitarla según sea necesario.
            this.clientesMovTableAdapter.Fill(this.dataSetClientesMovimientos.clientesMov);

            this.reportViewer1.RefreshReport();
        }
    }
}
