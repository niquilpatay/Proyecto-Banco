using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using banco.datos;
using banco.servicios.interfaz;
using banco.servicios;

namespace banco
{
    //INICIALIZACIÓN DE FORM
    public partial class frmNvoClienteCuenta : Form
    {
        List<Cliente> clientes;
        List<Cuenta> cuentas;
        private iServicio servicio; 

        /*private static frmNvoClienteCuenta instancia;

        public static frmNvoClienteCuenta obtenerInstancia()
        {
            if (instancia == null)
                instancia = new frmNvoClienteCuenta();
            return instancia;
        }*/
        public frmNvoClienteCuenta()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            cuentas = new List<Cuenta>();
            servicio = new implementacionFactoryServicio().crearServicio();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo(cboTipoCuenta);
            cargarGrilla();
            cargarGrilla2();
            habilitarCliente(false);
            habilitarCuenta(false);
        }

        //CARGAR GRILLAS Y COMBO CON SP
        private void cargarGrilla()
        {
            DataTable tabla = servicio.consultarBD("cargar_Cliente");
            dataGridView1.DataSource = tabla;
        }
        private void cargarGrilla2()
        {
            DataTable tabla = servicio.consultarBD("cargarCuentasActivas");
            dataGridView2.DataSource = tabla;
        }
        private void cargarGrilla3()
        {
            DataTable tabla = servicio.consultarBD("cargarCuentasInactivas");
            dataGridView2.DataSource = tabla;
        }
        private void cargarCombo(ComboBox combo)
        {
            DataTable tabla = servicio.consultarBD("cargar_tipoCuenta");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //BOTONES NUEVO + HABILITAR Y LIMPIAR
        private void habilitarCliente(bool v)
        {
            txtDNI.Enabled = v;     
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;           
            btn_Actualizar_Cliente.Enabled= v;
            btn_Agregar_Cliente.Enabled = v;
            btnBorrar_Cliente.Enabled = v;         
        }
        private void habilitarCuenta(bool v)
        {                   
            txtCBU_2.Enabled = v;
            txtDNI_2.Enabled = v;
            txtSaldo.Enabled = v;
            cboTipoCuenta.Enabled = v;
            dtpUltMov.Enabled = v;         
            btn_Agregar_Cuenta.Enabled = v;
            btn_Actualizar_Cuenta.Enabled = v;
            btnBorrar_Cuenta.Enabled = v;
            rbtActiva.Enabled = v;
            rbtInactiva.Enabled = v;
            btnDesactivar.Enabled = v;
            btnCuentasInactivas.Enabled = v;
        }
        private void limpiarCliente()
        {
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void btnNuevo_Cliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea actualizar un cliente: ingresar DNI, nombre y apellido.");
            MessageBox.Show("Si desea borrar un cliente, ingresar solo DNI.");
            limpiarCliente();
            habilitarCliente(true);
            txtDNI.Focus();
        }
        private void limpiarCuenta()
        {
            txtCBU_2.Text = "";
            txtDNI_2.Text = "";
            txtSaldo.Text = "";
            cboTipoCuenta.SelectedIndex = -1;
            dtpUltMov.Value = DateTime.Today;
            rbtActiva.Checked = false;
            rbtInactiva.Checked = false;
        }
        private void btnNueva_Cuenta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Si desea actualizar una cuenta, ingresar solo CBU y saldo/movimiento nuevo.");
            MessageBox.Show("Si desea borrar una cuenta, ingresar solo CBU.");
            MessageBox.Show("Si desea desactivar una cuenta, ingresar CBU e indicar estado de la misma.");
            cargarGrilla2();
            limpiarCuenta();
            habilitarCuenta(true);
            txtCBU_2.Focus();
        }

        //MÉTODOS EXISTE Y VALIDACIÓN DE DATOS
        private bool existeCliente(Cliente nuevo)
        {
            foreach(Cliente cl in clientes)
            {
                if(nuevo.Dni == cl.Dni)
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarDatosCliente()
        {
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Insertar DNI");
                txtDNI.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDNI.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtDNI.Focus();
                    return false;
                }
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Insertar nombre");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Insertar apellido");
                txtApellido.Focus();
                return false;
            }
            return true;
        }

        private bool existeCuenta(Cuenta nueva)
        {
            foreach (Cuenta cu in cuentas)
            {
                if (nueva.Cbu == cu.Cbu)
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarDatosCuenta()
        {
            if (txtDNI_2.Text == "")
            {
                MessageBox.Show("Insertar DNI");
                txtDNI_2.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDNI_2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtDNI_2.Focus();
                    return false;
                }
            }
            if (txtCBU_2.Text == "")
            {
                MessageBox.Show("Insertar CBU");
                txtCBU_2.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBU_2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtCBU_2.Focus();
                    return false;
                }
            }
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Insertar saldo");
                txtSaldo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(txtSaldo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtSaldo.Focus();
                    return false;
                }
            }
            if (cboTipoCuenta.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccionar tipo de cuenta");
                cboTipoCuenta.Focus();
                return false;
            }
            if(rbtActiva.Checked == false && rbtInactiva.Checked == false)
            {
                MessageBox.Show("Seleccionar si la cuenta está activa/inactiva.");
                rbtActiva.Focus();
                return false;
            }
            return true;
        }
        private bool validarDatosCuenta2()
        {
            if (txtCBU_2.Text == "")
            {
                MessageBox.Show("Insertar CBU");
                txtCBU_2.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtCBU_2.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtCBU_2.Focus();
                    return false;
                }
            }         
            if (txtSaldo.Text == "")
            {
                MessageBox.Show("Insertar saldo");
                txtSaldo.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(txtSaldo.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insertar solo números");
                    txtSaldo.Focus();
                    return false;
                }
            }         
            return true;
        }

        //BOTONES AGREGAR
        private void btn_Agregar_Actualizar_Cliente_Click(object sender, EventArgs e)
        {
            if (validarDatosCliente())
            {
                Cliente c = new Cliente();
                c.Dni = Convert.ToInt32(txtDNI.Text);
                c.Nombre = Convert.ToString(txtNombre.Text);
                c.Apellido = Convert.ToString(txtApellido.Text);

                if (!existeCliente(c))
                {
                    string nomSP = "insertar_Cliente";
                    List<Parametro> parametros = new List<Parametro>();
                    parametros.Add(new Parametro("@dni", c.Dni));
                    parametros.Add(new Parametro("@nombre", c.Nombre));
                    parametros.Add(new Parametro("@apellido", c.Apellido));

                    if ((servicio.actualizarBD(nomSP, parametros) == true))
                    {
                        MessageBox.Show("Se insertó cliente.");
                        limpiarCliente();
                        habilitarCliente(false);
                        cargarGrilla();
                    }
                }
            }
        }
        private void btn_Agregar_Actualizar_Cuenta_Click(object sender, EventArgs e)
        {
            if (validarDatosCuenta())
            {
                Cuenta cu = new Cuenta();
                cu.Cbu = Convert.ToInt32(txtCBU_2.Text);
                cu.Dni = Convert.ToInt32(txtDNI_2.Text);
                cu.Saldo = Convert.ToDouble(txtSaldo.Text);
                cu.Id_tipo_cuenta = Convert.ToInt32(cboTipoCuenta.SelectedValue);
                cu.UltimoMovimiento = Convert.ToDateTime(dtpUltMov.Value);
                if(rbtActiva.Checked == true)
                {
                    cu.Estado = 1;
                }
                else
                {
                    cu.Estado = 0;
                }

                if (!existeCuenta(cu))
                {
                    string nomSP = "insertar_Cuenta";
                    List<Parametro> parametros = new List<Parametro>();
                    parametros.Add(new Parametro("@cbu", cu.Cbu));
                    parametros.Add(new Parametro("@dni", cu.Dni));
                    parametros.Add(new Parametro("@saldo", cu.Saldo));
                    parametros.Add(new Parametro("@id_tipo_cuenta", cu.Id_tipo_cuenta));
                    parametros.Add(new Parametro("@ultimoMovimiento", cu.UltimoMovimiento));
                    parametros.Add(new Parametro("@estado", cu.Estado));


                    if ((servicio.actualizarBD(nomSP, parametros) == true))
                    {
                        MessageBox.Show("Se insertó cuenta.");
                        limpiarCuenta();
                        habilitarCuenta(false);
                        cargarGrilla2();
                    }
                }
            }
        }

        //BOTONES ACTUALIZAR
        private void btn_Actualizar_Cuenta_Click(object sender, EventArgs e)
        {


            if (validarDatosCuenta2())
            {
                int cbu = Convert.ToInt32(txtCBU_2.Text);
                double saldo = Convert.ToDouble(txtSaldo.Text);
                DateTime ultimoMovimiento = dtpUltMov.Value;

                if ((servicio.actualizarBD_SP_cuenta("actualizar_Cuenta2", cbu,saldo,ultimoMovimiento) == true))
                {
                        MessageBox.Show("Se actualizó cuenta.");
                        limpiarCuenta();
                        habilitarCuenta(false);
                        cargarGrilla2();
                }
                else
                {
                        MessageBox.Show("No se pudo insertar/actualizar cuenta.");
                }               
            }
        }
        private void btn_Actualizar_Cliente_Click(object sender, EventArgs e)
        {
            if (validarDatosCliente())
            {
                int dni = Convert.ToInt32(txtDNI.Text);
                string nombre = Convert.ToString(txtNombre.Text);
                string apellido = Convert.ToString(txtApellido.Text);

                if ((servicio.actualizarBD_SP2("actualizar_Cliente", dni,nombre,apellido) == true))
                {
                    MessageBox.Show("Se actualizó cliente.");
                    limpiarCliente();
                    habilitarCliente(false);
                    cargarGrilla();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar/actualizar cliente.");
                }
            }
        }

        //BOTONES BORRAR
        private void btnBorrar_Cuenta_Click(object sender, EventArgs e)
        {
            int cbu = Convert.ToInt32(txtCBU_2.Text);

            if (servicio.actualizarBD_SP3("eliminar_Cuenta", cbu) == true)
            {
                MessageBox.Show("Cuenta eliminada.");
                cargarGrilla2();
                limpiarCuenta();
                habilitarCuenta(false);
            }
            else
            {
                MessageBox.Show("No se pudo eliminar cuenta.");
                cargarGrilla2();
                limpiarCliente();
                habilitarCliente(false);
            }

        }
        private void btnBorrar_Cliente_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(txtDNI.Text);

            if(servicio.actualizarBD_SP4("eliminar_Cliente", dni) == true)
            {
                MessageBox.Show("Cliente eliminado.");
                cargarGrilla();
                limpiarCliente();
                habilitarCliente(false);
            }
            else
            {
                MessageBox.Show("Debe eliminar cuenta/s asociada/s a este cliente para continuar.");
                cargarGrilla();
                limpiarCliente();
                habilitarCliente(false);
            }

        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            int cbu = Convert.ToInt32(txtCBU_2.Text);
            int estado;
            if (rbtInactiva.Checked == true)
            {
                estado = 0;
            }
            else
            {
                estado = 1;
            }
            if (servicio.desactivarCuenta("desactivarCuenta",cbu,estado) == true)
            {
                MessageBox.Show("Cuenta desactivada.");

                limpiarCuenta();
                habilitarCliente(false);
                cargarGrilla2();
            }
            else
            {
                MessageBox.Show("Insertar CBU / Indicar que la cuenta está inactiva.");

                limpiarCuenta();
                habilitarCliente(false);
                cargarGrilla2();
            }
        }

        private void btnCuentasInactivas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Presione botón 'Nuevo' para mostrar cuentas activas.");
            cargarGrilla3();
        }

      
    }
}
